using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePocos.Models.Response
{
    public class ApiResponse
    {
        public Boolean HasError { get; set; }
        public String Message { get; set; }
    }

    public class ApiResponse<T> : ApiResponse
    {
        public T Data { get; set; }
    }
}
