using projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate;
using projeto.tcc.wallet.management.infra.data.Context;

namespace projeto.tcc.wallet.management.infra.data.Repository
{
	public class AssetRepository : Repository<Asset>,IAssetRepository
	{
		public AssetRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
		{
		}
	}
}