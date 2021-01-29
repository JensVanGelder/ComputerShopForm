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
    public partial class FormProductInfo : Form
    {
        //public IProduct FormInfoProduct;

        public FormProductInfo(IProduct product)
        {
            InitializeComponent();
            SetData(product);
        }

        public void SetData(IProduct product)
        {
            pictureBoxProductInfo.Load(product.ProductImagePath);
            txtBoxName.Text = product.Name;
            txtBoxPrice.Text = Convert.ToString(product.Price);
            txtBoxDescription.Text = product.ProductSummary;
            txtBoxId.Text = Convert.ToString(product.Id);

            //txtboxInfo.Text = product.ToString();
        }
    }
}