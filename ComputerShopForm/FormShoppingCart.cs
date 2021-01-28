using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormShoppingCart : Form
    {
        public ShoppingCart _cart;

        public FormShoppingCart()
        {
            InitializeComponent();
            _cart = ShoppingCart.GetShoppingCart();

            var q = from x in _cart.Shoppinglist
                    group x by x.Name into g
                    let count = g.Count()
                    orderby count descending
                    select new { Name = g.Key, Count = count, ID = g.First().Id };

            foreach (var x in q)
            {
                double price = 0;
                string path = "";
                foreach (var item in _cart.Shoppinglist)
                {
                    if (item.Name == x.Name)
                    {
                        path = item.ProductImagePath;
                        price = item.Price;
                    }
                }
                CartControl cartControl = new CartControl
                {
                    ProductName = x.Name,
                    Id = x.ID,
                    Count = x.Count,
                    ProductImagePath = path,
                    ProductPrice = price * x.Count,
                };
                flowLayoutPanel1.Controls.Add(cartControl);
            }

            lblTotalPrice.Text = $"Total: € {_cart.CalculatePrice()}";

            //foreach (IProduct product in _cart.Shoppinglist)
            //{
            //    CartControl cartControl = new CartControl
            //    {
            //        ProductName = product.Name,
            //        ProductPrice = product.Price,
            //        ProductImagePath = product.ProductImagePath,
            //        Id = product.Id,

            //    };
            //    flowLayoutPanel1.Controls.Add(cartControl);
            //}
            //CartControl cartControl2 = new CartControl();
            //label1.Text = cartControl2.CountOccurenceOfValue(5);
        }
    }
}