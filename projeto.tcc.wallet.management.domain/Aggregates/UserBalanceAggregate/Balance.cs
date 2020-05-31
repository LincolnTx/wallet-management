using System;
using System.Collections.Generic;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.UserBalanceAggregate
{
	public class Balance : Entity, IAggregateRoot
	{
		private string _userId;
		private decimal _totalPatrimony;
		private AssetBalance _assetBalance;
		

		protected Balance()
		{
		}

		public Balance(string userId, AssetBalance assetBalance)
		{
			_userId = userId;
			_assetBalance = assetBalance;
		}

		public void CalculateTotalPatrimony()
		{
			//mock
			_totalPatrimony = 10000;
		}
	}
}