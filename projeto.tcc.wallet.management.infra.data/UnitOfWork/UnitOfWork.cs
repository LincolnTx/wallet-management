using System.Threading.Tasks;
using projeto.tcc.wallet.management.domain.SeedWork;
using projeto.tcc.wallet.management.infra.data.Context;

namespace projeto.tcc.wallet.management.infra.data.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _applicationDbContext;

		public UnitOfWork(ApplicationDbContext applicationDbContext)
		{
			_applicationDbContext = applicationDbContext;
		}

		public async Task<bool> Commit()
		{
			return await _applicationDbContext.SaveEntitiesAsync();
		}

		public void Dispose()
		{
			_applicationDbContext.Dispose();
		}
	}
}