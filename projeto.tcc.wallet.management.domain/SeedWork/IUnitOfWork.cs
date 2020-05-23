using System;
using System.Threading.Tasks;

namespace projeto.tcc.wallet.management.domain.SeedWork
{
	public interface IUnitOfWork : IDisposable
	{
		Task<bool> Commit();
	}
}