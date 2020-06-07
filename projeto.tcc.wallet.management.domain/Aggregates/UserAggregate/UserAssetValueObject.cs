using System;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.UserAggregate
{
	public class UserAssetValueObject : ValueObject
	{
		public string Name {get; private set; }
		public string Symbol {get; private set; }
		public decimal StartPrice {get; private set; }

		public UserAssetValueObject(string name, string symbol, decimal startPrice)
		{
			Name = name;
			Symbol = symbol;
			StartPrice = startPrice;
		}
	}
}