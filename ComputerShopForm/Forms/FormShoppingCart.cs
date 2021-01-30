using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormShoppingCart : Form
    {
        private ShoppingCart _cart;
        private ILogger _logger;

        public FormShoppingCart()
        {
            InitializeComponent();
            _cart = ShoppingCart.GetShoppingCart();
            _logger = new JsonLogger();
            CreateCombinedShoppingList();

            //button remove
        }

        public void CreateCombinedShoppingList()
        {
            if (_cart.Shoppinglist != null)
            {
                button1.Visible = false;
                if (_cart.Shoppinglist.Count != 0)
                {
                    button1.Visible = true;
                    var uniqueCart = from product in _cart.Shoppinglist
                                     group product by product.Name into groupProduct
                                     let countUniqueProduct = groupProduct.Count()
                                     orderby countUniqueProduct descending
                                     select new { Name = groupProduct.Key, Count = countUniqueProduct, ID = groupProduct.First().Id };

                    GenerateUserControls(uniqueCart);
                    lblTotalPrice.Text = $"Total:           € {_cart.CalculatePrice()}";
                }
            }
        }

        public void GenerateUserControls(IEnumerable<dynamic> uniqueCart)
        {
            foreach (var product in uniqueCart)
            {
                double price = 0;
                string path = "";
                foreach (var item in _cart.Shoppinglist)
                {
                    if (item.Name == product.Name)
                    {
                        path = item.ProductImagePath;
                        price = item.Price;
                    }
                }
                UserControlCart cartControl = new UserControlCart
                {
                    PName = product.Name,
                    Id = product.ID,
                    Count = product.Count,
                    ProductImagePath = path,
                    ProductPrice = price * product.Count,
                };
                cartControl.RemoveItemButtonClicked += RemoveItemButtonClicked;
                flowLayoutPanel1.Controls.Add(cartControl);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string message = $"Your total price is € {_cart.CalculatePrice()}" +
                $"\n\nComplete your purchase?";
            DialogResult dr = MessageBox.Show(message, "Payment Screen", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                _logger.LogPurchase(_cart);
                _cart.ClearCart();
                MessageBox.Show("Thank you for your purchase", "Purchase Completed");
                this.Close();
            }
        }

        private void lblTotalPrice_Click(object sender, System.EventArgs e)
        {
        }

        private void RemoveItemButtonClicked(object sender, EventArgs e)
        {
            var userControl = sender as UserControlCart;
            foreach (var item in _cart.Shoppinglist)
            {
                if (item.Name == userControl.PName)
                {
                    _cart.Shoppinglist.Remove(item);
                    break;
                }
            }
            flowLayoutPanel1.Controls.Clear();
            CreateCombinedShoppingList();
        }
    }
}