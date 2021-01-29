using System;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class UserControlShop : UserControl
    {
        public ShoppingCart _cart;
        public IProductsRepo _repo;

        public UserControlShop()
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

        public event EventHandler AddToCartButtonClicked;

        private void btnAddToShoppingCart_Click(object sender, EventArgs e)
        {
            OnAddToShoppingCartButtonClicked(e);
        }

        protected virtual void OnAddToShoppingCartButtonClicked(EventArgs e)
        {
            AddToCartButtonClicked?.Invoke(this, e);
        }
    }
}