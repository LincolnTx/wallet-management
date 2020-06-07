using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using projeto.tcc.wallet.management.api.v1.Filters;
using projeto.tcc.wallet.management.application.Commands;
using projeto.tcc.wallet.management.application.CommandsHandlers;
using projeto.tcc.wallet.management.infra.crosscutting.ioc.Configuration;

namespace projeto.tcc.wallet.management.api.v1
{
	public class Startup
	{
		 public Startup(IHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(env.ContentRootPath)
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();        
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // var appSettings = Configuration.GetSection("Configuracoes").Get<AppSettings>();
            // var connectionString = Environment.GetEnvironmentVariable("ConnectionString");


            services.AddDatabaseSetup();
            // services.AddHealthCheckSetup(connectionString);
            services.ConfigAutoMapper();
            services.AddDependencyInjectionSetup();
            services.AddSwaggerSetup();
            services.AddMediatR(typeof(CommandHandler).GetTypeInfo().Assembly);
            // services.AddMemoryCache();
            services.AddScoped<GlobalExceptionFilterAttribute>();


            services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseRouting();

            //TODO
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                // app.UseHealthCheck(endpoints);
            });

            app.UseSwaggerSetup();
        }
	}
}