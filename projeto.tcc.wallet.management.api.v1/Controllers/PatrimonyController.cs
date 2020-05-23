using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projeto.tcc.wallet.management.domain.Exceptions;

namespace projeto.tcc.wallet.management.api.v1.Controllers
{
	public class PatrimonyController : BaseController
	{
		private readonly IMediator _mediator;
		
		protected PatrimonyController(INotificationHandler<ExceptionNotification> notifications) : base(notifications)
		{
			_mediator = _mediator;
		}
	}
}