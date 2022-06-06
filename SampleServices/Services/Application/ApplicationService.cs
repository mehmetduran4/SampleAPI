using SamplePocos.Models.Menu;
using SamplePocos.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services.Application
{
    public class ApplicationService
    {
        private MenuItems _mMenus { get; set; }
        private Orders _mOrders { get; set; }
        private MenuCategories _mCategories { get; set; }

        public ApplicationService()
        {
            _mMenus = new MenuItems();
            _mOrders = new Orders();
            _mCategories = new MenuCategories();
            Load();
        }

        private void Load()
        {
            LoadMenuCategories();
            LoadMenuItems();
        }

        private void LoadMenuCategories()
        {
            _mCategories.AddRange(SampleMenuCategories.SampleItems);
        }

        private void LoadMenuItems()
        {
            _mMenus.AddRange(SampleMenuItems.SampleItems);
        }

        public MenuItems MenuItems 
        { 
            get 
            { 
                return _mMenus; 
            } 
        }

        public Orders Orders 
        { 
            get 
            { 
                return _mOrders; 
            } 
        }

        public MenuCategories Categories
        { 
            get 
            { 
                return _mCategories; 
            } 
        }
    }
}
