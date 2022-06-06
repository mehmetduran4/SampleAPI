using SamplePocos.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePocos.Models.Order
{
    public class Order
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public List<int> MenuItems { get; set; } = new List<int>();
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; } = OrderStatus.Preparing;
        public MenuItems Items { get; set; }

        public Order Clone()
        {
            return (Order)MemberwiseClone();
        }
    }
}
