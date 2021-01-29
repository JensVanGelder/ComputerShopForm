using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormShoppingCart : Form
    {
        public ShoppingCart _cart;
        public ILogger _logger;

        public FormShoppingCart()
        {
            InitializeComponent();
            _cart = ShoppingCart.GetShoppingCart();
            _logger = new JsonLogger();

            if (_cart.Shoppinglist != null)
            {
                var uniqueCart = from product in _cart.Shoppinglist
                                 group product by product.Name into groupProduct
                                 let countUniqueProduct = groupProduct.Count()
                                 orderby countUniqueProduct descending
                                 select new { Name = groupProduct.Key, Count = countUniqueProduct, ID = groupProduct.First().Id };

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
                    flowLayoutPanel1.Controls.Add(cartControl);
                }

                lblTotalPrice.Text = $"Total:           € {_cart.CalculatePrice()}";
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
    }
}