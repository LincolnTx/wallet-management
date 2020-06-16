using Microsoft.EntityFrameworkCore;
using projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate;
using projeto.tcc.wallet.management.infra.data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace projeto.tcc.wallet.management.infra.data.Repository
{
    public class AssetRepository : Repository<Asset>, IAssetRepository
    {
        public AssetRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public async Task<Asset> GetAssetBySymbol(string symbol)
        {
            return await _dbSet.FirstOrDefaultAsync(X => X._symbol == symbol);
        }
    }
}