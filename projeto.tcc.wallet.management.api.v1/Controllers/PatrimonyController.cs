using MediatR;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using projeto.tcc.wallet.management.application.Commands;
using projeto.tcc.wallet.management.domain.Exceptions;

namespace projeto.tcc.wallet.management.api.v1.Controllers
{
	public class PatrimonyController : BaseController
	{
		private readonly IMediator _mediator;
		
		public PatrimonyController(INotificationHandler<ExceptionNotification> notifications, IMediator mediator) : base(notifications)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> EfetiveOrder([FromBody] ExecuteOrderCommand executeOrderCommand)
		{
			await _mediator.Send(executeOrderCommand);
			
			return Response(10, null);
		}
	}
}