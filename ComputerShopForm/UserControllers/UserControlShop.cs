using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class UserControlShop : UserControl
    {
        public IShoppingCart _cart;
        public IProductsRepo _repo;
        public IProduct _product;

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
            set
            {
                CultureInfo be = new CultureInfo("en-FR");
                lblProductPrice.Text = value.ToString("C", be);
            }
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

        private int _productStock;

        public int ProductStock
        {
            get { return _productStock; }
            set
            {
                if (value <= 0)
                {
                    btnAddToShoppingCart.BackColor = Color.Gray;
                    btnAddToShoppingCart.Enabled = false;
                }
                _productStock = value;
                lblProductStock.Text = $"Stock: {value}";
            }
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
                    lblSameDayDelivery.ForeColor = Color.FromArgb(203, 0, 0);
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {
            var productforinfo = _repo.GetProduct(ProductName);
            FormProductInfo productinfoform = new FormProductInfo(productforinfo);
            productinfoform.Show();
        }

        private void lblProductName_MouseHover(object sender, EventArgs e)
        {
            lblProductName.ForeColor = Color.DarkBlue;
        }

        private void lblProductName_MouseLeave(object sender, EventArgs e)
        {
            lblProductName.ForeColor = Color.Blue;
        }
    }
}