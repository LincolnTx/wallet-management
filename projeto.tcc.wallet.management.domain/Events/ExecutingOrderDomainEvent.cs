using System;

namespace projeto.tcc.wallet.management.domain.Events
{
	public class ExecutingOrderDomainEvent : Event
	{
		public Guid UserId { get; }
		public string Name { get; }
		public string Symbol { get; }
		public decimal StartPrice { get; }

		public ExecutingOrderDomainEvent(Guid userId, string name, string symbol, decimal startPrice)
		{
			UserId = userId;
			Name = name;
			Symbol = symbol;
			StartPrice = startPrice;
		}
	}
}