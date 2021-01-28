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

        public UserController1()
        {
            InitializeComponent();
        }

        private void UserController1_Load(object sender, EventArgs e)
        {
        }
    }
}