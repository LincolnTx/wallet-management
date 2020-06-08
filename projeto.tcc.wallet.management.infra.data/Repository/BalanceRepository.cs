using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate;
using projeto.tcc.wallet.management.infra.data.Context;

namespace projeto.tcc.wallet.management.infra.data.Repository
{
	public class BalanceRepository : Repository<UserBalance>, IBalanceRepository
	{
		public BalanceRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
		
		
		public async Task<UserBalance> GetBalanceByUserId(Guid userId)
		{
			return  await _dbSet.FirstOrDefaultAsync(user => user._userId == userId);
		}
	}
}