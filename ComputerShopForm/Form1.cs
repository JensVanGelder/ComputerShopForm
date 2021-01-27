using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class Form1 : Form
    {
        private ShoppingCart shoppingcart = new ShoppingCart();

        private IProduct testproduct1 = new Desktop("testcomputer1", 1000.3);
        private IProduct testproduct2 = new Desktop("testcomputer2", 1500.3);
        private IProduct testproduct3 = new Desktop("testcomputer3", 1600.3);
        private IProduct testproduct4 = new Desktop("testcomputer4", 1900.3);

        public Form1()
        {
            InitializeComponent();
            shoppingcart.AddProductToCart(testproduct4);
            shoppingcart.AddProductToCart(testproduct2);
            shoppingcart.AddProductToCart(testproduct3);
            shoppingcart.AddProductToCart(testproduct1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = shoppingcart.ShowShoppingCart();
        }
    }
}