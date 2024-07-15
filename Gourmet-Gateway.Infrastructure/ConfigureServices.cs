using System;
using Gourmet_Gateway.Application.Interfaces;
using Gourmet_Gateway.Application.Services;
using Gourmet_Gateway.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gourmet_Gateway.Infrastructure
{
	public static class ConfigureServices
	{
		public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<GourmetGatewayDbContext>(o => o.UseNpgsql(configuration.GetConnectionString("GGDb")));
			services.AddScoped<IMenuService, MenuService>();
			services.AddScoped<IMenuRepository, MenuRepository>();
			return services;
		}
	}
}

