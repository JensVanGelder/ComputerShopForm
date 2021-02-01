using System;
using System.Collections.Generic;
using System.Globalization;
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
        }

        public void CreateCombinedShoppingList()
        {
            if (_cart.ShoppingList != null)
            {
                button1.Visible = false;

                if (_cart.ShoppingList.Count != 0)
                {
                    button1.Visible = true;
                    var uniqueCart = from product in _cart.ShoppingList
                                     group product by product.Name into groupProduct
                                     let countUniqueProduct = groupProduct.Count()
                                     select new { Name = groupProduct.Key, Count = countUniqueProduct, ID = groupProduct.First().Id };

                    GenerateUserControls(uniqueCart);
                }
            }
            SetPriceLabels();
        }


        public void GenerateUserControls(IEnumerable<dynamic> uniqueCart)
        {
            foreach (var product in uniqueCart)
            {
                double price = 0;
                string path = "";

                foreach (var item in _cart.ShoppingList.Where(item => item.Name == product.Name))
                {
                    path = item.ProductImagePath;
                    price = item.Price;
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

        public void SetPriceLabels()
        {
            PriceCalculator calculator = new PriceCalculator();
            lblTotalPrice.Text = _cart.GetPrice().ToString("C2", CultureInfo.CreateSpecificCulture("en-FR"))
            +"\n" + (_cart.GetPrice()*calculator.Tax).ToString("C2", CultureInfo.CreateSpecificCulture("en-FR"))
            +"\n"+ _cart.GetPriceWithTax().ToString("C2", CultureInfo.CreateSpecificCulture("en-FR"));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string message = $"{_cart.CartInfo}" +
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

        private void RemoveItemButtonClicked(object sender, EventArgs e)
        {
            if (sender is UserControlCart userControl)
            {
                _cart.RemoveProductFromCart(userControl.PName);
            }

            flowLayoutPanel1.Controls.Clear();
            CreateCombinedShoppingList();
        }

        private void userControlCart1_Load(object sender, EventArgs e)
        {

        }
    }
}