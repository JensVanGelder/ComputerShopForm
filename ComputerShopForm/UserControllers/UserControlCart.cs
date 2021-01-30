using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class UserControlCart : UserControl
    {
        public ShoppingCart _cart;
        public IProductsRepo _repo;

        public UserControlCart()
        {
            InitializeComponent();
            _cart = ShoppingCart.GetShoppingCart();
            _repo = new ProductsRepo();
        }

        public int Id { get; set; }

        public string PName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public int Count
        {
            get { return Convert.ToInt32(lblCount.Text); }
            set { lblCount.Text += value.ToString(); }
        }

        public double ProductPrice
        {
            get { return Convert.ToDouble(lblPrice.Text); }
            set { lblPrice.Text = $"€ {value}"; }
        }

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

        public event EventHandler RemoveItemButtonClicked;

        private void button1_Click(object sender, EventArgs e)
        {
            OnRemoveItemButtonClicked(e);
        }

        protected virtual void OnRemoveItemButtonClicked(EventArgs e)
        {
            RemoveItemButtonClicked?.Invoke(this, e);
        }
    }
}