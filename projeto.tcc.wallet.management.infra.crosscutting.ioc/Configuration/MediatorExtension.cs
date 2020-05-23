using System.Linq;
using System.Threading.Tasks;
using MediatR;
using projeto.tcc.wallet.management.domain.SeedWork;
using projeto.tcc.wallet.management.infra.data.Context;

namespace projeto.tcc.wallet.management.infra.crosscutting.ioc.Configuration
{
	static class MediatorExtension
	{
		public static async Task DispatchDomainEventsAsync(this IMediator mediator, ApplicationDbContext context)
		{
			var domainEntities = context.ChangeTracker
				.Entries<Entity>()
				.Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any());

			var domainEvents = domainEntities
				.SelectMany(x => x.Entity.DomainEvents)
				.ToList();

			domainEntities.ToList()
				.ForEach(entity => entity.Entity.ClearDomainEvent());
			
			foreach (var domainEvent in domainEvents)
			{
				await mediator.Publish(domainEvent);
			}
		}
	}
}