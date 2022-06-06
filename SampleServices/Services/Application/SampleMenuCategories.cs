using SamplePocos.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services.Application
{
    public class SampleMenuCategories
    {
        private static MenuCategories _items = new MenuCategories()
        {
            new MenuCategory() { Id = 1, Name = "Kebaps", Order = 2 },
            new MenuCategory() { Id = 2, Name = "Drinks", Order = 3 },
            new MenuCategory() { Id = 3, Name = "Soup of the Day", Order = 1 }
        };

        public static MenuCategories SampleItems
        {
            get
            {
                return _items;
            }
        }
    }
}
