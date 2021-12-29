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
            InitializeComponent();
            Product test1 = new Product();
            test1.Name = "Card";
            test1.Price = 4.99;
            test1.StockNum = 678;

            Console.WriteLine("total cost is: " + Product.GetTotalCost(test1.Price, test1.StockNum));
        }
    }
}
