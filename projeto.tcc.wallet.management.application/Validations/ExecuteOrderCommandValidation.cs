using System;
using FluentValidation;
using projeto.tcc.wallet.management.application.Commands;

namespace projeto.tcc.wallet.management.application.Validations
{
	public class ExecuteOrderCommandValidation : AbstractValidator<ExecuteOrderCommand> 
	{
		public ExecuteOrderCommandValidation()
		{
			ValidateUserId();
			ValidateSymbol();
			ValidadeIsCloseOrder();
			ValidateValue();
		}

		protected void ValidateUserId()
		{
			RuleFor(executeOrder => executeOrder.UserId)
				.NotEmpty()
				.WithMessage("Campo userId obrigatório");
		}

		protected void ValidateSymbol()
		{
			RuleFor(executeOrder => executeOrder.Asset.Symbol)
				.NotEmpty()
				.NotNull()
				.WithMessage("Campo symbol obrigatório");
		}

		protected void ValidadeIsCloseOrder()
		{
			RuleFor(executeOrder => executeOrder.IsCloseOrder)
				.NotNull();
		}

		protected void ValidateValue()
		{
			RuleFor(executeOrder => executeOrder.Ammount)
				.GreaterThan(0)
				.NotNull();
		}
	}
}