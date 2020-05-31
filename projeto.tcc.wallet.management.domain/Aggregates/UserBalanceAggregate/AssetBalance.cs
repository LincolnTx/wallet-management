using System.Collections.Generic;

namespace projeto.tcc.wallet.management.domain.Aggregates.UserBalanceAggregate
{
	public class AssetBalance
	{
		private decimal _transientBalance;
		
		private AssetValueObject _acquiredAsset;

		public AssetBalance(AssetValueObject acquiredAsset)
		{
			_acquiredAsset = _acquiredAsset;
		}

		public void CalculateTransienBalance()
		{
			//mock
			_transientBalance =  1000;
		}
		
	}
}