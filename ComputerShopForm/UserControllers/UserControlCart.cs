using System;
using System.Globalization;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class UserControlCart : UserControl
    {
        public UserControlCart()
        {
            InitializeComponent();
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
            set { lblPrice.Text = $"{value.ToString("C2", CultureInfo.CreateSpecificCulture("en-FR"))}"; }
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
                    picProductImage.ImageLocation = _productImagePath;
                    picProductImage.Load(_productImagePath);
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