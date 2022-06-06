using SamplePocos.Models.Order;
using SamplePocos.Models.Response;
using SampleServices.Services.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private ApplicationService _applicationService { get; set; }

        public OrderService(ApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public ApiResponse<int> Add(Order item)
        {
            if (item != null && item.MenuItems.Count > 0)
            {
                var check = true;
                foreach (var menuItem in item.MenuItems)
                {
                    if(!_applicationService.MenuItems.Any(p=>p.Id == menuItem))
                    {
                        check = false;
                    }
                }
                if (check)
                {
                    _applicationService.Orders.Add(item);
                    return new ApiResponse<int>(){ Data = 1 };
                }
                else
                {
                    throw new Exception("Invalid Menu Item");
                }
            }
            throw new Exception("Invalid Operation");
        }

        public ApiResponse<int> Update(Order item)
        {
            throw new Exception("Not Implemented");
        }

        public ApiResponse<int> Delete(int id)
        {
            throw new Exception("Not Implemented");
        }

        public ApiResponse<List<Order>> GetList(OrderFilter filter)
        {
            return new ApiResponse<List<Order>>()
            {
                Data = _applicationService.Orders.OrderBy(p=>p.OrderDate).Select((p) =>
                {
                    var item  = p.Clone();
                    item.Items = new SamplePocos.Models.Menu.MenuItems();
                    foreach (var find in item.MenuItems)
                    {
                        var menuItem = _applicationService.MenuItems.FirstOrDefault(p=>p.Id == find).Clone();
                        menuItem.Days = null;
                        item.Items.Add(menuItem);
                    }
                    item.MenuItems = null;
                    return item;
                }).ToList()
            };
        }

        public ApiResponse<Order> GetOrder(string orderId)
        {
            if (_applicationService.Orders.Any(p=>p.Id == orderId))
            {
                var find = _applicationService.Orders.FirstOrDefault(p=>p.Id == orderId).Clone();
                find.Items = new SamplePocos.Models.Menu.MenuItems();
                foreach (var item in find.MenuItems)
                {
                    var menuItem = _applicationService.MenuItems.FirstOrDefault(p=>p.Id == item).Clone();
                    menuItem.Days = null;
                    find.Items.Add(menuItem);
                }
                find.MenuItems = null;
                return new ApiResponse<Order>()
                {
                    Data = find
                };
            }
            throw new Exception("Order Not Found");
        }
    }
}
