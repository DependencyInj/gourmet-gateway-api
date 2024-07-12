using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gourmet_Gateway.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gourmet_Gateway.APIs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            this._menuService = menuService;
        }

        [HttpGet(Name = "menus")]
        public async Task<IActionResult> GetMenus()
        {
            var result = await _menuService.GetMenus();
            return Ok(result);
        }
    }
}

