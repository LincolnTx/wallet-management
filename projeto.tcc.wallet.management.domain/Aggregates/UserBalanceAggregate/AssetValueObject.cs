using System;
using projeto.tcc.wallet.management.domain.SeedWork;

namespace projeto.tcc.wallet.management.domain.Aggregates.UserBalanceAggregate
{
	public class AssetValueObject : ValueObject
	{
		private string _name;
		private string _symbol;
		private string _imageUrl;
		private string _segment;
		private DateTime _startDate;
		private decimal _startPrice;

		public AssetValueObject(string name, string symbol, string imageUrl, string segment, DateTime startDate,
			decimal startPrice)
		{
			_name = name;
			_symbol = symbol;
			_imageUrl = imageUrl;
			_segment = segment;
			_startDate = startDate;
			_startPrice = startPrice;
		}
	}
}