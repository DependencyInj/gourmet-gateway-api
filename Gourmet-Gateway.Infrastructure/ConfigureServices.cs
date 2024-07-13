using System;
using Gourmet_Gateway.Application.Interfaces;
using Gourmet_Gateway.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gourmet_Gateway.Infrastructure
{
	public static class ConfigureServices
	{
		public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<IMenuService, MenuService>();
			return services;
		}
	}
}

