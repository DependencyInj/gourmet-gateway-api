using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gourmet_Gateway.Application.DTO;
using Gourmet_Gateway.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gourmet_Gateway.APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService ;

        public MenuController(IMenuService menuService)
        {
            this._menuService = menuService;
        }

        [HttpGet("/api/menus")]
        public async Task<IActionResult> GetMenus()
        {
            var result = await _menuService.GetMenus();
            return Ok(result);
        }

        [HttpGet("/api/menu-types")]
        public async Task<IActionResult> GetMenuTypes()
        {
            var result = await _menuService.GetMenuTypes();
            return Ok(result);
        }

        [HttpPost("/api/add")]
        public async Task<IActionResult> AddMenuItem([FromBody] MenuDTO menuDTO)
        {
            var result = await _menuService.AddMenuItem(menuDTO);
            return Ok(result); 
        }

        [HttpDelete("/api/delete")]
        public async Task<IActionResult> RemoveMenuItem(int menuItemId)
        {
            
            await _menuService.RemoveMenuItem(menuItemId);
            return Ok(true);
        }
    }
}

