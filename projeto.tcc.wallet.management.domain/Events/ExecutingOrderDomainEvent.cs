namespace projeto.tcc.wallet.management.domain.Events
{
	public class ExecutingOrderDomainEvent : Event
	{
		public string Name { get; }
		public string Symbol { get; }
		public decimal StartPrice { get; }

		public ExecutingOrderDomainEvent(string name, string symbol, decimal startPrice)
		{
			Name = name;
			Symbol = symbol;
			StartPrice = startPrice;
		}
	}
}