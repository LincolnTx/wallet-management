using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace projeto.tcc.wallet.management.application.EventHandlers
{
	public abstract class EventHandler <T> : INotificationHandler<T> where T : INotification 
	{

		public EventHandler()
		{
		}

		public abstract Task Handle(T notification, CancellationToken cancellationToken);
	}
}