using System;
using Gourmet_Gateway.Application.DTO;
using Gourmet_Gateway.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Gourmet_Gateway.Infrastructure.Repositories
{
	public class MenuRepository: IMenuRepository
	{
		private readonly GourmetGatewayDbContext _dbContex;
		public MenuRepository(GourmetGatewayDbContext dbContext)
		{
			this._dbContex = dbContext;
		}

        public async Task<List<MenuDTO>> GetMenus()
        {
			try
			{
				var results = await (from m in _dbContex.Menus
									 join mt in _dbContex.Menu_Types on m.menu_type_id equals mt.menu_type_id
									 select new MenuDTO
									 {
										 Name = m.name,
										 Description = m.description,
										 Price = m.price,
										 Type = mt.name,
										 Image = m.image
									 }).ToListAsync();
				return results;
			}
			catch (Exception e)
			{
				throw e;
			}
        }
    }
}

