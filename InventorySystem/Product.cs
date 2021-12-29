using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int ItemSKU { get; set; }
        public int StockNum { get; set; }

        public static double GetTotalCost(double price, int stock)
        {
            return price * stock;
        }
    }
}
