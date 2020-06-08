using MediatR;
using Microsoft.Extensions.DependencyInjection;
using projeto.tcc.wallet.management.application.Commands;
using projeto.tcc.wallet.management.application.CommandsHandlers;
using projeto.tcc.wallet.management.domain.Aggregates.AssetAggregate;
using projeto.tcc.wallet.management.domain.Aggregates.BalanceAggregate;
using projeto.tcc.wallet.management.domain.Exceptions;
using projeto.tcc.wallet.management.domain.SeedWork;
using projeto.tcc.wallet.management.infra.data.Context;
using projeto.tcc.wallet.management.infra.data.Mappings;
using projeto.tcc.wallet.management.infra.data.Repository;
using projeto.tcc.wallet.management.infra.data.UnitOfWork;

namespace projeto.tcc.wallet.management.infra.crosscutting.ioc
{
	public class NativeInjectorBootstrapper
	{
		public static void RegisterServices(IServiceCollection services)
		{
			RegisterData(services);
			RegisterMediatR(services);

		}

		private static void RegisterData(IServiceCollection services)
		{
			services.AddScoped<IBalanceRepository, BalanceRepository>();
			services.AddScoped<IAssetRepository, AssetRepository>();
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			services.AddScoped<ApplicationDbContext>();
		}

		private static void RegisterMediatR(IServiceCollection services)
		{
			services.AddScoped<INotificationHandler<ExceptionNotification>, ExceptionNotificationHandler>();
			services.AddScoped<IRequestHandler<ExecuteOrderCommand, bool>, ExecuteOrderCommandHandler>();
		}
	}
}