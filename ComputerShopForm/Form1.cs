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

        public Form1()
        {
            InitializeComponent();
            /*shoppingcart.AddProductToCart(testproduct4); //vervangen door foreach om lijst met producten
            shoppingcart.AddProductToCart(testproduct2);
            shoppingcart.AddProductToCart(testproduct3);
            shoppingcart.AddProductToCart(testproduct1);*/

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