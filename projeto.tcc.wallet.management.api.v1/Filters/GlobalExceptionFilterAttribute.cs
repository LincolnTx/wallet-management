using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace projeto.tcc.wallet.management.api.v1.Filters
{
	public class GlobalExceptionFilterAttribute
	{
		public GlobalExceptionFilterAttribute() { }

		public void OnException(ExceptionContext  context)
		{
			context.Result = new BadRequestObjectResult(
				new
				{
					success = false,
					errors = new []
					{
						new
						{
							Code = "188",
							Message = "Não foi possível realizar a operação",
							timesTamp = DateTime.Now
						}
					}
				}
			);
		}
	}
}