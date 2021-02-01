using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormShop : Form
    {
        public ProductsRepo _repo;
        private ShoppingCart _cart;
        private IList<UserControlShop> _controls;

        public FormShop()
        {
            InitializeComponent();
            _repo = new ProductsRepo();
            _cart = ShoppingCart.GetShoppingCart();
            _controls = new List<UserControlShop>();
            _repo.prods = _repo.CreateProductList();
            GenerateProductControls(_repo.prods);
        }

        private void GenerateProductControls(IEnumerable<IProduct> products)
        {
            foreach (IProduct product in products)
            {
                var usercontrol = new UserControlShop(_repo)
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
                var product = _repo.GetProduct(userControl.Id,_repo.prods);
                _cart.AddProductToCart(product);
                lblItemsInCart.Visible = true;
                picCartButtonCircle.Visible = true;
                lblItemsInCart.Text = $"{_cart.ShoppingList.Count}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _controls.Clear();
            flowMainShopPanel.Controls.Clear();
            GenerateProductControls(_repo.prods);
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

        private void FormShop_Activated(object sender, EventArgs e)
        {
            lblItemsInCart.Text = _cart.ShoppingList.Count().ToString();
        }

        private void chkGaming_CheckedChanged(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowMainShopPanel.Controls)
            {
                string input = "fortnite";
                if (control.ProductFullInfo.ToLower().Contains(input))
                {
                    control.Visible = true;
                }
            }
        }

        private void chkWorkstation_CheckedChanged(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowMainShopPanel.Controls)
            {
                string input = "workstation";
                if (control.ProductFullInfo.ToLower().Contains(input))
                {
                    control.Visible = true;
                }
            }
        }

        private void chkLaptop_CheckedChanged(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowMainShopPanel.Controls)
            {
                control.Visible = false;
                string input = chkLaptop.Text.ToLower();
                if (control.ProductFullInfo.ToLower().Contains(input))
                {
                    control.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProductInfo editable = new FormProductInfo(this);
            editable.Show();
        }
    }
}