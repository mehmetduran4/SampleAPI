using SamplePocos.Models.Menu;
using SamplePocos.Models.Response;
using SampleServices.Services.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services.MenuService
{
    public class MenuService : IMenuService
    {
        private ApplicationService _applicationService { get; set; }

        public MenuService(ApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public ApiResponse<int> Add(MenuItem item)
        {
            if (item != null && !_applicationService.MenuItems.Any(p=>p.Id == item.Id))
            {
                _applicationService.MenuItems.Add(item);
                return new ApiResponse<int>(){ Data = 1 };
            }
            throw new Exception("Invalid Operation");
        }

        public ApiResponse<int> Update(MenuItem item)
        {
            if (item != null && _applicationService.MenuItems.Any(p=>p.Id == item.Id))
            {
                var findIndex = _applicationService.MenuItems.FindIndex(p=>p.Id == item.Id);
                _applicationService.MenuItems[findIndex] = item;
                return new ApiResponse<int>(){ Data = 1 };
            }
            throw new Exception("Invalid Operation");
        }

        public ApiResponse<int> Delete(int id)
        {
            if (id > 0 && _applicationService.MenuItems.Any(p=>p.Id == id))
            {
                var find = _applicationService.MenuItems.FirstOrDefault(p=>p.Id == id);
                _applicationService.MenuItems.Remove(find);
                return new ApiResponse<int>(){ Data = 1 };
            }
            throw new Exception("Invalid Operation");
        }

        public ApiResponse<List<MenuItem>> GetList(MenuFilter filter)
        {
            return new ApiResponse<List<MenuItem>>()
            {
                Data = _applicationService.MenuItems.Where(p=>p.Days.IndexOf(filter.DayIndex) > -1).Select((p) => 
                {
                    var result = p.Clone();
                    result.Category = _applicationService.Categories.FirstOrDefault(x=>x.Id == p.CategoryId);
                    result.Days = null;
                    return result;
                }).OrderBy(p => p.Category.Order).ThenBy(p=>p.Order).ToList()
            };
        }
    }
}
