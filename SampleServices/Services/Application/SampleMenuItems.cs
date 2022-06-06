using SamplePocos.Models.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServices.Services.Application
{
    public class SampleMenuItems
    {
        private static MenuItems _items = new MenuItems()
        {
            #region Çorbalar
            new MenuItem()
            {
                Id = 1,
                CategoryId = 3,
                Name = "Mercimek Çorbası",
                Description = "Klasik Mercimek Çorbası",
                SizeOrExplanation = "400 ml",
                Price = 26,
                Order = 1,
                Days = new List<int>(){ 0,1,2,3,4,5,6 }
            },
            new MenuItem()
            {
                Id = 2,
                CategoryId = 3,
                Name = "Ezogelin Çorbası",
                Description = "Klasik EzoGelin Çorbası",
                SizeOrExplanation = "400 ml",
                Price = 25,
                Order = 2,
                Days = new List<int>(){ 1,2,3 }
            },
            new MenuItem()
            {
                Id = 3,
                CategoryId = 3,
                Name = "Tarhana Çorbası",
                Description = "Klasik Tarhana Çorbası",
                SizeOrExplanation = "400 ml",
                Price = 30,
                Order = 3,
                Days = new List<int>(){ 5,6 }
            },
            #endregion

            #region İçecekler
            new MenuItem()
            {
                Id = 4,
                CategoryId = 2,
                Name = "Su",
                Description = "Su",
                SizeOrExplanation = "500 ml",
                Price = 5,
                Order = 1,
                Days = new List<int>(){ 0,1,2,3,4,5,6 }
            },
            new MenuItem()
            {
                Id = 5,
                CategoryId = 2,
                Name = "Ayran",
                Description = "Yayık Ayran",
                SizeOrExplanation = "300 ml",
                Price = 15,
                Order = 2,
                Days = new List<int>(){ 0,1,2,3,4,5,6 }
            },
            new MenuItem()
            {
                Id = 6,
                CategoryId = 2,
                Name = "Soda",
                Description = "Sade Soda",
                SizeOrExplanation = "200 ml",
                Price = 10,
                Order = 3,
                Days = new List<int>(){ 0,1,2,3,4,5,6 }
            },
            new MenuItem()
            {
                Id = 7,
                CategoryId = 2,
                Name = "Kahve",
                Description = "Filtre Kahve",
                SizeOrExplanation = "250 ml",
                Price = 15,
                Order = 4,
                Days = new List<int>(){ 4,5,6 }
            },
            #endregion

            #region Ana Yemekler
            new MenuItem()
            {
                Id = 8,
                CategoryId = 1,
                Name = "Adana Kebap",
                Description = "Klasik Adana Kebabı",
                SizeOrExplanation = "120 gr",
                Price = 35,
                Order = 1,
                Days = new List<int>(){ 0,1,2,3,4,5,6 }
            },
            new MenuItem()
            {
                Id = 9,
                CategoryId = 1,
                Name = "Alinazik",
                Description = "Klasik Alinazik Kebabı",
                SizeOrExplanation = "120 gr",
                Price = 45,
                Order = 2,
                Days = new List<int>(){ 0,1,2,3,4,5,6 },
                IsNew = true
            },
            new MenuItem()
            {
                Id = 10,
                CategoryId = 1,
                Name = "Et Şiş",
                Description = "Klasik Et Şiş",
                SizeOrExplanation = "100 gr",
                Price = 40,
                Order = 3,
                Days = new List<int>(){ 0,1,2,3,4,5,6 }
            },
            new MenuItem()
            {
                Id = 11,
                CategoryId = 1,
                Name = "Tavuk Şiş",
                Description = "Klasik Tavuk Şiş",
                SizeOrExplanation = "100 gr",
                Price = 30,
                Order = 4,
                Days = new List<int>(){ 0,1,2,3,4,5,6 }
            },
            #endregion
        };

        public static MenuItems SampleItems
        {
            get
            {
                return _items;
            }
        }
    }
}
