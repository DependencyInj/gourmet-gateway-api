using System;
using Gourmet_Gateway.Application.DTO;
using Gourmet_Gateway.Application.Interfaces;

namespace Gourmet_Gateway.Application.Services
{
	public class MenuService: IMenuService
	{
		private readonly IMenuRepository menuRepository;

		public MenuService(IMenuRepository menuRepository)
		{
			this.menuRepository = menuRepository;
		}

		public async Task<List<MenuDTO>> GetMenus()
		{
            return await menuRepository.GetMenus();
		}

		public async Task<List<MenuTypeDTO>> GetMenuTypes()
		{
			return await menuRepository.GetMenuTypes();
		}

		public async Task<MenuDTO> AddMenuItem(MenuDTO menuDTO)
		{
			return await menuRepository.AddMenuItem(menuDTO);
		}

        public async Task<bool> RemoveMenuItem(int menuItemId)
        {
            return await menuRepository.RemoveMenuItem(menuItemId);
        }
    }
}

