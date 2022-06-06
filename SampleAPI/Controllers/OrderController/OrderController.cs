using Microsoft.AspNetCore.Mvc;
using SamplePocos.Models.Menu;
using SamplePocos.Models.Response;
using SampleServices.Services.OrderService;
using System.Collections.Generic;
using SamplePocos.Models.Order;

namespace SampleAPI.Controllers.OrderController
{
    [Route("api/order/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private OrderService _orderService {get;set;}

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public ApiResponse<int> Add(Order item)
        {
            return _orderService.Add(item);
        }

        [HttpPost]
        public ApiResponse<int> Update(Order item)
        {
            return _orderService.Update(item);
        }

        [HttpPost]
        public ApiResponse<int> Delete(int id)
        {
            return _orderService.Delete(id);
        }

        [HttpPost]
        public ApiResponse<List<Order>> GetList(OrderFilter filter)
        {
            return _orderService.GetList(filter);
        }

        [HttpGet]
        public ApiResponse<Order> GetOrder(string orderId)
        {
            return _orderService.GetOrder(orderId);
        }
    }
}
