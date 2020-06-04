using System.Threading;
using System.Threading.Tasks;
using MediatR;
using projeto.tcc.wallet.management.application.Commands;
using projeto.tcc.wallet.management.domain.Exceptions;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.application.CommandsHandlers
{
	public class ExecuteOrderCommendHandler : CommandHandler, IRequestHandler<ExecuteOrderCommand, bool>
	{
		public ExecuteOrderCommendHandler(INotificationHandler<ExceptionNotification> notifications, IMediator bus, IUnitOfWork uow = null) : base(notifications, bus, uow)
		{
		}

		public async Task<bool> Handle(ExecuteOrderCommand request, CancellationToken cancellationToken)
		{
			if (!request.IsValid())
			{
				NotifyValidationErrors(request);
				return false;
			}
			
		}
	}
}