using System;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.UserBalanceAggregate
{
	public class AssetValueObject : ValueObject
	{
		private string _name;
		private string _symbol;
		private DateTime _startDate;
		private decimal _startPrice;

		public AssetValueObject(string name, string symbol, DateTime startDate, decimal startPrice)
		{
			_name = name;
			_symbol = symbol;
			_startDate = startDate;
			_startPrice = startPrice;
		}
	}
}