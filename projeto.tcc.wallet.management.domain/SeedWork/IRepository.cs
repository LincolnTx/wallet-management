﻿namespace projeto.tcc.wallet.management.domain.SeedWork
{
	public interface IRepository<TEntity> where TEntity : IAggregateRoot
	{
		void Add(TEntity obj);
	}
}