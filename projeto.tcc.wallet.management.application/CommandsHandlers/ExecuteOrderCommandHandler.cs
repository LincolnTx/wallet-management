using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using projeto.tcc.wallet.management.application.Commands;
using projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate;
using projeto.tcc.wallet.management.domain.Exceptions;
using projeto.tcc.wallet.management.domain.SeedWork;
using AutoMapper;

namespace projeto.tcc.wallet.management.application.CommandsHandlers
{
	public class ExecuteOrderCommandHandler : CommandHandler, IRequestHandler<ExecuteOrderCommand, bool>
	{
		private readonly  IBalanceRepository _balanceRepository;
		public ExecuteOrderCommandHandler(
			INotificationHandler<ExceptionNotification> notifications,
			IMediator bus,
			IUnitOfWork uow,
			IBalanceRepository balanceRepository
			) : base(notifications,
			bus,
			uow)
		{
			_balanceRepository = balanceRepository;
		}

		public async Task<bool> Handle(ExecuteOrderCommand request, CancellationToken cancellationToken)
		{
			if (!request.IsValid())
			{
				NotifyValidationErrors(request);
				return false;
			}
			
			var user = await _balanceRepository.GetBalanceByUserId(request.UserId);
			
			 if (!user.VerifyBalance( request.Asset.StartPrice))
			 {
				 await _bus.Publish(new ExceptionNotification("001", "Seu saldo não é suficiente para realizar essa ação"), cancellationToken);
				 return false;
			 }
			 user.ExecuteOrderAndCalculateTotalBalance(request.Asset.Name, request.Asset.Symbol, request.Asset.StartPrice);

			 return await Commit();
		}
	}
}