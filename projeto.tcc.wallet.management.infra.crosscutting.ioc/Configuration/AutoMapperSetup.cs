using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace projeto.tcc.wallet.management.infra.crosscutting.ioc.Configuration
{
	public static class AutoMapperSetup
	{
		public static void ConfigAutoMapper(this IServiceCollection services)
		{
			if (services == null) throw new ArgumentException(nameof(services));
			
			// services.AddAutoMapper();
		}
	}
}