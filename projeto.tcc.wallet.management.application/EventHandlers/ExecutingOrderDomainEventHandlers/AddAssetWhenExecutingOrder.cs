using System.Threading;
using System.Threading.Tasks;
using projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate;
using projeto.tcc.wallet.management.domain.Events;

namespace projeto.tcc.wallet.management.application.EventHandlers.ExecutingOrderDomainEventHandlers
{
	public class AddAssetWhenExecutingOrder : EventHandler<ExecutingOrderDomainEvent>
	{
		private readonly IAssetRepository _assetRepository;

		public AddAssetWhenExecutingOrder(IAssetRepository assetRepository)
		{
			_assetRepository = assetRepository;
		}

		public override Task Handle(ExecutingOrderDomainEvent notification, CancellationToken cancellationToken)
		{
			var asset = new Asset(notification.UserId, notification.Symbol, notification.StartPrice);
			_assetRepository.Add(asset);
			return Task.CompletedTask;
		}
	}
}