using System;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Gourmet_Gateway.Application
{
	public static class ConfigureServices
	{

		public static IServiceCollection AddApplicationService(this IServiceCollection services)
		{
			services.AddAutoMapper(Assembly.GetExecutingAssembly());
			return services;
		}
	}
}

