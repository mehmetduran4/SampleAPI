using Microsoft.AspNetCore.Mvc;
using SamplePocos.Models.Menu;
using SamplePocos.Models.Response;
using SampleServices.Services.MenuService;
using System.Collections.Generic;

namespace SampleAPI.Controllers.MenuController
{
    [Route("api/menu/[action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private MenuService _menuService {get;set;}

        public MenuController(MenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpPost]
        public ApiResponse<int> Add(MenuItem item)
        {
            return _menuService.Add(item);
        }

        [HttpPost]
        public ApiResponse<int> Update(MenuItem item)
        {
            return _menuService.Update(item);
        }

        [HttpPost]
        public ApiResponse<int> Delete(int menuItemId)
        {
            return _menuService.Delete(menuItemId);
        }

        [HttpPost]
        public ApiResponse<List<MenuItem>> GetList(MenuFilter filter)
        {
            return _menuService.GetList(filter);
        }
    }
}
