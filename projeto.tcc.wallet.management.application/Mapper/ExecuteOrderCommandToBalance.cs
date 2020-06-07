using System;
using AutoMapper;
using projeto.tcc.wallet.management.application.Commands;
using projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate;

namespace projeto.tcc.wallet.management.application.Mapper
{
	public class ExecuteOrderCommandToBalance : Profile
	{
		private ExecuteOrderCommandToBalance()
		{
		}

		private void CreateNewBalanceCommandMappingProfile()
		{
			CreateMap<ExecuteOrderCommand, UserBalance>();
			// .ConstructUsing((x) => new UserBalance(x.Item1.UserId, x.Item2));
		}
	}
}