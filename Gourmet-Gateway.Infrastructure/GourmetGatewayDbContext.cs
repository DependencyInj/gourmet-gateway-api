using System;
using Microsoft.EntityFrameworkCore;

namespace Gourmet_Gateway.Infrastructure
{
	public class GourmetGatewayDbContext: DbContext
	{
		public GourmetGatewayDbContext(DbContextOptions<GourmetGatewayDbContext> options) : base(options)
		{
		}
	}
}

