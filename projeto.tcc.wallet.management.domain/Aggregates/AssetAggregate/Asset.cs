using System;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate
{
	public class Asset : Entity, IAggregateRoot
	{
		private Guid _userId;
		public string _symbol { get; private set; }
		public decimal _startPrice { get; private set; }

        public Asset(Guid userId, string symbol, decimal startPrice)
		{
			_userId = userId;
			_symbol = symbol;
			_startPrice = startPrice;
		}
	}
}