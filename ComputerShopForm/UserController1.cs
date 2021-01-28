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
    public partial class UserController1 : UserControl
    {
        public ShoppingCart _cart;
        public IProductsRepo _repo;

        public UserController1()
        {
            InitializeComponent();
            _cart = ShoppingCart.GetShoppingCart();
            _repo = new ProductsRepo();
        }

        public int Id { get; set; }

        public string ProductName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public double ProductPrice { get; set; }
        public string ProductSummary { get; set; }
        private string _productImagePath;

        public string ProductImagePath
        {
            set
            {
                if (value != null)
                {
                    _productImagePath = value;
                    pictureBox1.ImageLocation = _productImagePath;
                    pictureBox1.Load(_productImagePath);
                }
            }
        }

        /*public bool SameDayDelivery
        {
            get { return lblSameDayDelivery.Text; }
            set { lblName.Text = value; }
        }*/

        private void UserController1_Load(object sender, EventArgs e)
        {
        }

        private void btnAddToShoppingCart_Click(object sender, EventArgs e)
        {
            var product = _repo.GetProduct(ProductName);
            _cart.AddProductToCart(product);
        }
    }
}