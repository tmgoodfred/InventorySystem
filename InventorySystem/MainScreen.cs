using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            List<Product> products = new List<Product>();
            InitializeComponent();
            Product test1 = new Product();
            test1.Name = "Card";
            test1.Description = "This is a card. Quite a simple thing, isn't it?";
            test1.ItemSKU = 43512345; 
            test1.Price = 4.99;
            test1.StockNum = 678;
            products.Add(test1);

            Console.WriteLine("total cost is: " + Product.GetTotalCost(test1));
        }
    }
}
