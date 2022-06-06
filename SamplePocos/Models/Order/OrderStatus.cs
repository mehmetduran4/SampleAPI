using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePocos.Models.Order
{
    public enum OrderStatus : int
    {
        Preparing = 0,
        Prepared = 1,
        Sent = 2,
        Closed = 3
    }
}
