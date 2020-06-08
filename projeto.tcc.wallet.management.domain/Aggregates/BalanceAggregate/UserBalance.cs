using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using projeto.tcc.wallet.management.domain.Events;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate
{
	public class UserBalance : Entity, IAggregateRoot
	{
		public Guid _userId { get; private set; }
		public Guid GetUserID => _userId; 

		private decimal _totalPatrimony;
		private decimal _transientBalance;


		protected UserBalance()
		{
		}

		
		public void ExecuteOrderAndCalculateTotalBalance(string name,string symbol, decimal startPrice)
		{
			_totalPatrimony -= startPrice;
			AddDomainEvent(new ExecutingOrderDomainEvent(this._userId, name, symbol, startPrice));
		}
		
		public bool VerifyBalance(decimal startPrice)
		{
			return _totalPatrimony >= startPrice;
		}
		public UserBalance(Guid userId)
		{
			_userId = userId;
		}
		
	}
}