using System;
   using System.Threading.Tasks;
   using projeto.tcc.wallet.management.domain.SeedWork;
   
   namespace projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate
   {
   	public interface IBalanceRepository : IRepository<UserBalance>
   	{
   		// somente get ById
   		 Task<UserBalance> GetBalanceByUserId(Guid userId);

        //Task Update();

       }
   }