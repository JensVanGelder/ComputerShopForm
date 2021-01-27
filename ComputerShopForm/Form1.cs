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
            shoppingcart.AddProductToCart(testproduct4); //vervangen door foreach om lijst met producten
            shoppingcart.AddProductToCart(testproduct2);
            shoppingcart.AddProductToCart(testproduct3);
            shoppingcart.AddProductToCart(testproduct1);

            int locationX = 0;

            foreach (IProduct product in shoppingcart.Shoppinglist)
            {
                locationX += 200;
                UserController1 testcontroller = new UserController1();
                testcontroller.Name = product.Name;

                flowLayoutPanel1.Controls.Add(testcontroller);

                // UserController1.Name = product.Name;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}