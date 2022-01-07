using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger
{
    public class Orders
    {
        public Menus Menus { get; set; }
        public List<Materials> Materials { get; set; }
        public int Quantity { get; set; }
        public MenuSize Size { get; set; }
        public decimal TotalPrice { get; set; }


        public void Calculate()
        {
            TotalPrice = 0;
            TotalPrice += Menus.MenuPrice;

            switch (Size)
            {
                case MenuSize.Kucuk:
                    TotalPrice += 3;
                    break;
                case MenuSize.Orta:
                    TotalPrice += 6;
                    break;
                case MenuSize.Buyuk:
                    TotalPrice += 9;
                    break;
            }
            foreach (Materials item in Materials)
            {
                TotalPrice += item.MaterialPrice;
            }
        }
        public override string ToString()
        {
            return Menus.MenuName + " x " + Quantity + " Adet (" + GetMaterials() + ") Price = " + "₺ " + TotalPrice;
        }

        string GetMaterials()
        {
            string materialsName = "";
            foreach (var item in Materials)
            {
                materialsName += item.MaterialName + ", ";
            }
            return materialsName;
        }
    }
}
