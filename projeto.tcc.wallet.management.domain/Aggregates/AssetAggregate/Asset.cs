using System;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate
{
	public class Asset : Entity, IAggregateRoot
	{
		private Guid _userId;
		private string _name;
		private string _symbol;
		private decimal _startPrice;

		public Asset(Guid userId,string name, string symbol, decimal startPrice)
		{
			_userId = userId;
			_name = name;
			_symbol = symbol;
			_startPrice = startPrice;
		}
	}
}