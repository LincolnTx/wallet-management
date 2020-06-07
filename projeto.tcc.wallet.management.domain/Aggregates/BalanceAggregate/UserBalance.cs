using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using projeto.tcc.wallet.management.domain.Events;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate
{
	public class UserBalance : Entity, IAggregateRoot
	{
		private Guid _userId;
		private decimal _totalPatrimony;
		public decimal GetTotalPatrimony => _totalPatrimony; 
		private decimal _transientBalance;


		protected UserBalance()
		{
		}

		
		public void ExecuteOrderAndCalculateTotalBalance(string name,string symbol, decimal startPrice)
		{
			_totalPatrimony -= startPrice;
			AddDomainEvent(new ExecutingOrderDomainEvent(name, symbol, startPrice));
		}
		
		public bool VerifyBalance(decimal startPrice)
		{
			return startPrice >= this.GetTotalPatrimony;
		}
		public UserBalance(Guid userId)
		{
			_userId = userId;
		}
		
	}
}