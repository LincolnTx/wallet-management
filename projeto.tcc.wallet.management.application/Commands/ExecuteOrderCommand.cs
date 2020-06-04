using System;
using FluentValidation.Results;
using MediatR;
using projeto.tcc.wallet.management.application.Validations;

namespace projeto.tcc.wallet.management.application.Commands
{
	public class ExecuteOrderCommand : Command, IRequest<bool>
	{
		public Guid UserId { get; set; }
		public string Symbol { get; set; }
		public bool IsCloseOrder { get; set; }
		public decimal Value { get; set; }
		
		public override bool IsValid()
		{
			ValidationResult = new ExecuteOrderCommandValidation().Validate(this);

			return ValidationResult.IsValid;
		}
	}
}