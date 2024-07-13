using System;
using Gourmet_Gateway.Application.DTO;
using Gourmet_Gateway.Application.Interfaces;

namespace Gourmet_Gateway.Application.Services
{
	public class MenuService: IMenuService
	{
		public MenuService()
		{
		}

		public async Task<List<MenuDTO>> GetMenus()
		{
			List<MenuDTO> menuDTOs = new List<MenuDTO>();
			menuDTOs.Add(new MenuDTO { Name = "Biriyani", Description = "Testing", Price = 100, Type = "ML" });
			return menuDTOs;
		} 
	}
}

