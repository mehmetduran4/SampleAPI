using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamplePocos.Models.Menu;
using SampleServices.Base;

namespace SampleServices.Services.MenuService
{
    public interface IMenuService : IBase<MenuItem, MenuFilter>
    {

    }
}
