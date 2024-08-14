using System;
using Gourmet_Gateway.Application.DTO;

namespace Gourmet_Gateway.Application.Interfaces
{
	public interface IMenuRepository
	{
        Task<List<MenuDTO>> GetMenus();
        Task<List<MenuTypeDTO>> GetMenuTypes();
        Task<MenuDTO> AddMenuItem(MenuDTO menuDTO);
        Task<bool> RemoveMenuItem(int menuItemId);
    }
}

