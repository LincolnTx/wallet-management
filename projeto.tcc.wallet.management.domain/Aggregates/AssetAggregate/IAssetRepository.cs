using projeto.tcc.wallet.management.domain.SeedWork;
using System.Threading.Tasks;

namespace projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate
{
	public interface IAssetRepository : IRepository<Asset>
	{
        Task<Asset> GetAssetBySymbol(string symbol);

    }
}