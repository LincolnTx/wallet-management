using Microsoft.EntityFrameworkCore;
using projeto.tcc.wallet.management.domain.SeedWork;
using projeto.tcc.wallet.management.infra.data.Context;

namespace projeto.tcc.wallet.management.infra.data.Repository
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IAggregateRoot
	{
		protected readonly ApplicationDbContext _applicationDbContext;
		protected readonly DbSet<TEntity> _dbSet;

		public Repository(ApplicationDbContext applicationDbContext)
		{
			_applicationDbContext = _applicationDbContext;
			_dbSet = applicationDbContext.Set<TEntity>();
		}

		public void Add(TEntity obj)
		{
			_applicationDbContext.Add(obj);
		}
		
	}
}