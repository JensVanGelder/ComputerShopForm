using System;
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

        public new string ProductName
        {
            get { return lblProductName.Text; }
            set { lblProductName.Text = value; }
        }
              
        public double ProductPrice
        {
            get { return Convert.ToDouble(lblProductPrice.Text); }
            set { lblProductPrice.Text = $"{value},00 EUR"; }
        }

        public string ProductSummary
        {
            get { return lblProductSummary.Text; }
            set { lblProductSummary.Text = value; }
        }

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

        public int ProductStock
        {
            get { return Convert.ToInt32(lblProductStock.Text); }
            set { lblProductStock.Text = $"{value}"; }
        }

        public bool SameDayDelivery
        {
            get { return Convert.ToBoolean(lblSameDayDelivery.Text); }
            set 
            {
                if (ProductStock > 0)
                {
                    lblSameDayDelivery.Text = $"Morgen bij jou";
                }
                else
                {
                    lblSameDayDelivery.Text = $"Tijdelijk niet in voorraad";
                }
            }             
                
        }

        private void UserController1_Load(object sender, EventArgs e)
        {
        }

        private void btnAddToShoppingCart_Click(object sender, EventArgs e)
        {
            var product = _repo.GetProduct(Id);
            _cart.AddProductToCart(product);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}