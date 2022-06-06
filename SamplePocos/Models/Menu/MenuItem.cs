using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePocos.Models.Menu
{
    public class MenuItem
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public MenuCategory Category { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public String SizeOrExplanation { get; set; }
        public String Description { get; set; }
        public String Note { get; set; }
        public List<String> Items { get; set; }
        public int Order { get; set; }
        public List<int> Days { get; set; } = new List<int>();

        public MenuItem Clone()
        {
            return (MenuItem)MemberwiseClone();
        }
    }
}
