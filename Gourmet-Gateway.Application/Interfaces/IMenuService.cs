using System;
using Gourmet_Gateway.Application.DTO;

namespace Gourmet_Gateway.Application.Interfaces
{
	public interface IMenuService
	{
		Task<List<MenuDTO>> GetMenus();
	}
}

