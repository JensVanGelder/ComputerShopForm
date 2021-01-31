using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormShop : Form
    {
        private IProductsRepo _repo;
        private IShoppingCart _cart;
        private IList<UserControlShop> _controls;

        public FormShop()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
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
                    Id = product.Id,
                };

                usercontrol.AddToCartButtonClicked += AddToCartClickedInUserControl;
                _controls.Add(usercontrol);
            }

            flowLayoutPanel1.Controls.AddRange(_controls.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShoppingCart cart = new FormShoppingCart();
            cart.Show();
        }

        private void AddToCartClickedInUserControl(object sender, EventArgs e)
        {
            if (sender is UserControlShop userControl)
            {
                var product = _repo.GetProduct(userControl.ProductName);
                _cart.AddProductToCart(product);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowLayoutPanel1.Controls)
            {
                if (control.ProductName == "HP Oblivion III")
                {
                    control.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowLayoutPanel1.Controls)
            {
                control.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowLayoutPanel1.Controls)
            {
                control.Visible = false;
                string prodname = control.ProductName.ToLower();
                string input = textBox1.Text.ToLower();
                if (prodname.Contains(input))
                {
                    control.Visible = true;
                }
            }
            //var selectedControls = _controls.Where(x => x.ProductName.ToLower() == textBox1.Text.ToLower()).Select(y => y.Visible = true).ToList();
            //_controls.Where(x => x.ProductName.ToLower() == textBox1.Text.ToLower()).Select(y=>y.Visible=true);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}