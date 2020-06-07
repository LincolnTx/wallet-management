using System;
using AutoMapper.Configuration.Annotations;
using Microsoft.Extensions.DependencyInjection;
using projeto.tcc.wallet.management.infra.data.Context;

namespace projeto.tcc.wallet.management.infra.crosscutting.ioc.Configuration
{
	public static class DependencyInjectionSetup
	{
		public static void AddDependencyInjectionSetup(this IServiceCollection services)
		{
			if (services == null) throw new ArgumentNullException(nameof(services));
			
			NativeInjectorBootstrapper.RegisterServices(services);
		}
	}
}