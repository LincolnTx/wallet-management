using System.Threading;
using System.Threading.Tasks;
using projeto.tcc.wallet.management.domain.Events;

namespace projeto.tcc.wallet.management.application.EventHandlers
{
	public class AddAssetWhenExecutingOrder : EventHandler<ExecutingOrderDomainEvent>
	{
		public override Task Handle(ExecutingOrderDomainEvent notification, CancellationToken cancellationToken)
		{
			// add assets
			return Task.CompletedTask;
		}
	}
}