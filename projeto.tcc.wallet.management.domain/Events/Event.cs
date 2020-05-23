using System;
using MediatR;

namespace projeto.tcc.wallet.management.domain.Events
{
	public abstract class Event : INotification
	{
		public DateTime Timestamp { get; private set; }

		protected Event()
		{
			Timestamp = DateTime.Now;
		}
	}
}