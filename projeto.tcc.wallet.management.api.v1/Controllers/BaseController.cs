using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using projeto.tcc.wallet.management.api.v1.Filters;
using projeto.tcc.wallet.management.domain.Exceptions;

namespace projeto.tcc.wallet.management.api.v1.Controllers
{
	[Route("wallet/management/[controller]")]
	[ServiceFilter(typeof(GlobalExceptionFilterAttribute))]
	public class BaseController : Controller
	{
		private readonly ExceptionNotificationHandler _notifications;

		protected IEnumerable<ExceptionNotification> Notifications => _notifications.GetNotifications();

		protected BaseController(INotificationHandler<ExceptionNotification> notifications)
		{
			_notifications = (ExceptionNotificationHandler) notifications;
		}

		protected bool IsValidOperation()
		{
			return (!_notifications.HasNotifications());
		}

		protected new IActionResult Response(int statusCode, object result = null)
		{
			if (IsValidOperation())
			{
				return StatusCode(statusCode, new
				{
					success = true,
					data = result
				});
			}

			return BadRequest(new
			{
				success = false,
				errors = _notifications.GetNotifications()
			});
		}
	}
}