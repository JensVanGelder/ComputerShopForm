using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormShop : Form
    {
        private IProductsRepo _repo;
        private ShoppingCart _cart;
        private IList<UserControlShop> _controls;

        public FormShop()
        {
            InitializeComponent();
            _repo = new ProductsRepo();
            _cart = ShoppingCart.GetShoppingCart();
            _controls = new List<UserControlShop>();

            IList<IProduct> productList = _repo.CreateProductList();
            GenerateProductControls(productList);
        }

        private void GenerateProductControls(IEnumerable<IProduct> products)
        {
            foreach (IProduct product in products)
            {
                var usercontrol = new UserControlShop
                {
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductImagePath = product.ProductImagePath,
                    ProductSummary = product.ProductSummary,
                    ProductStock = product.Stock,
                    SameDayDelivery = true,
                    ProductFullInfo = product.ToString(),
                    Id = product.Id,
                };

                usercontrol.AddToCartButtonClicked += AddToCartClickedInUserControl;
                _controls.Add(usercontrol);
            }

            flowMainShopPanel.Controls.AddRange(_controls.ToArray());
        }

        private void AddToCartClickedInUserControl(object sender, EventArgs e)
        {
            if (sender is UserControlShop userControl)
            {
                var product = _repo.GetProduct(userControl.ProductName);
                _cart.AddProductToCart(product);
                lblItemsInCart.Visible = true;
                picCartButtonCircle.Visible = true;
                lblItemsInCart.Text = $"{_cart.ShoppingList.Count}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowMainShopPanel.Controls)
            {
                if (control.ProductName == "HP Oblivion III")
                {
                    control.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowMainShopPanel.Controls)
            {
                control.Visible = true;
            }
        }

        private void txtSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (UserControlShop control in flowMainShopPanel.Controls)
                {
                    control.Visible = false;
                    string input = txtSearchBar.Text.ToLower();
                    if (control.ProductName.ToLower().Contains(input) || control.ProductSummary.ToLower().Contains(input)
                        || control.ProductFullInfo.ToLower().Contains(input))
                    {
                        control.Visible = true;
                    }
                }
            }
        }

        private void rndbtnShoppingCart_Click(object sender, EventArgs e)
        {
            FormShoppingCart cart = new FormShoppingCart();
            cart.Show();
        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            if (txtSearchBar.Text == "What are you looking for?")
            {
                txtSearchBar.Text = "";
            }
        }
    }
}