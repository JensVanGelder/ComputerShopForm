using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormShop : Form
    {
        private IProductsRepo _repo;
        private IShoppingCart _cart;

        public FormShop()
        {
            InitializeComponent();
            _repo = new ProductsRepo();
            _cart = ShoppingCart.GetShoppingCart();

            var products = _repo.CreateProductList();
            GenerateProductControls(products);
        }

        private void GenerateProductControls(IEnumerable<IProduct> products)
        {
            foreach (IProduct product in products)
            {
                UserControlShop usercontrol = new UserControlShop
                {
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductImagePath = product.ProductImagePath,
                    Id = product.Id,
                };
                flowLayoutPanel1.Controls.Add(usercontrol);
                usercontrol.AddToCartButtonClicked += AddToCartClickedInUserControl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShoppingCart cart = new FormShoppingCart();
            cart.Show();
        }

        private void AddToCartClickedInUserControl(object sender, EventArgs e)
        {
            var userControl = sender as UserControlShop;
            var product = _repo.GetProduct(userControl.ProductName);
            _cart.AddProductToCart(product);
        }
    }
}