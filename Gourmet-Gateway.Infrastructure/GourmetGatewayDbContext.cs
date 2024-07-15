using System;
using Gourmet_Gateway.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Gourmet_Gateway.Infrastructure
{
	public class GourmetGatewayDbContext: DbContext
	{
		public GourmetGatewayDbContext(DbContextOptions<GourmetGatewayDbContext> options) : base(options)
		{
		}

		public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Menu_Type> Menu_Types { get; set; }
    }
}

