using SamplePocos.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Base
{
    public interface IBase<T, F>
    {
        public ApiResponse<int> Add(T model);
        public ApiResponse<int> Update(T model);
        public ApiResponse<int> Delete(int id);
        public ApiResponse<List<T>> GetList(F filter);
    }
}
