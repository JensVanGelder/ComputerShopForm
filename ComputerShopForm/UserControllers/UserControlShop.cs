using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class UserControlShop : UserControl
    {
        private IProductsRepo _repo;

        public UserControlShop()
        {
            InitializeComponent();
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

        public string ProductFullInfo { get; set; }
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
                lblSameDayDelivery.Text = ProductStock > 0 ? "Delivered tomorrow!" : "Currently out of stock.";
                lblSameDayDelivery.ForeColor = ProductStock > 0 ? Color.DarkSeaGreen : Color.FromArgb(206, 0, 0);
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

        private void lblProductName_Click(object sender, EventArgs e)
        {
            var productforinfo = _repo.GetProduct(Id);
            FormProductInfo productinfoform = new FormProductInfo(productforinfo);
            productinfoform.Show();
        }

        private void lblProductName_MouseHover(object sender, EventArgs e)
        {
            lblProductName.ForeColor = Color.DarkBlue;
            this.BackColor = Color.WhiteSmoke;
        }

        private void lblProductName_MouseLeave(object sender, EventArgs e)
        {
            lblProductName.ForeColor = Color.DodgerBlue;
            this.BackColor = Color.White;
        }
    }
}