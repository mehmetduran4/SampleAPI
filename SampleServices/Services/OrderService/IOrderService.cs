using SamplePocos.Models.Order;
using SamplePocos.Models.Response;
using SampleServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services.OrderService
{
    public interface IOrderService  : IBase<Order, OrderFilter>
    {
        public ApiResponse<Order> GetOrder(string orderId);
    }
}
