using System;

namespace projeto.tcc.wallet.management.domain.Events
{
	public class ExecutingOrderDomainEvent : Event
	{
		public Guid UserId { get; set; }
		public string Symbol { get; set; }
		public decimal StartPrice { get; set; }
        public int Ammount { get; set; }
		public ExecutingOrderDomainEvent(Guid userId, string symbol, decimal startPrice, int ammount)
		{
			UserId = userId;
			Symbol = symbol;
			StartPrice = startPrice;
            Ammount = ammount;
		}
	}
}