using System;
using Gourmet_Gateway.Application.DTO;
using Gourmet_Gateway.Application.Interfaces;
using Gourmet_Gateway.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Gourmet_Gateway.Infrastructure.Repositories
{
	public class MenuRepository : IMenuRepository
	{
		private readonly GourmetGatewayDbContext _dbContext;
		public MenuRepository(GourmetGatewayDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public async Task<List<MenuDTO>> GetMenus()
		{
			try
			{
				var results = await (from m in _dbContext.Menus
									 join mt in _dbContext.Menu_Types on m.menu_type_id equals mt.menu_type_id
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

		public async Task<List<MenuTypeDTO>> GetMenuTypes()
		{
			try
			{
				var result = await _dbContext.Menu_Types
					.Select(mt => new MenuTypeDTO
					{
						name = mt.name,
						code = mt.code,
						description = mt.description
					}).ToListAsync();

				return result;
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public async Task<MenuDTO> AddMenuItem(MenuDTO menuDTO)
		{
			var menuType = await _dbContext.Menu_Types.Where(item => item.code == menuDTO.Type).FirstOrDefaultAsync();

			Menu menu = new Menu()
			{
				name = menuDTO.Name,
				description = menuDTO!.Description!,
				image = menuDTO!.Image!,
				menu_type_id = menuType!.menu_type_id!,
				price = menuDTO.Price
			};

			await _dbContext.Menus.AddAsync(menu);
			await _dbContext.SaveChangesAsync();

			return menuDTO;
		}
	}
}

