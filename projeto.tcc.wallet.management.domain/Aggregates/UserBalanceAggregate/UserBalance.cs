using System;
using System.Collections.Generic;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.UserBalanceAggregate
{
	public class UserBalance : Entity, IAggregateRoot
	{
		private string _userId;
		private ICollection<AssetValueObject> _listAcquiredAssets;

		protected UserBalance()
		{
		}

		public UserBalance(string userId, ICollection<AssetValueObject> listAcquiredAssets)
		{
			_userId = userId;
			_listAcquiredAssets = listAcquiredAssets;
		}
	}
}