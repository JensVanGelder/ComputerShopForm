using System;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormProductInfo : Form
    {
        public FormProductInfo(IProduct product)
        {
            InitializeComponent();
            SetData(product);
        }

        public void SetData(IProduct product)
        {
            AddComputerInfo(product);
            AddTypeInfo(product);
            txtboxInfo.Text = product.ToString();
        }

        public void AddComputerInfo(IProduct product)
        {
            var computer = product as Computer;
            pictureBoxProductInfo.Load(computer.ProductImagePath);
            txtBoxName.Text = computer.Name;
            txtBoxRam.Text = Convert.ToString(computer.Ram);
            txtBoxMoBo.Text = computer.MoBo;
            txtBoxPsu.Text = computer.Psu;
            txtBoxCpu.Text = computer.Cpu;
            txtBoxHdd.Text = computer.Hdd;
            txtBoxStock.Text = Convert.ToString(computer.Stock);
            txtBoxPrice.Text = Convert.ToString(product.Price);
            txtBoxDescription.Text = product.ProductSummary;
            txtBoxId.Text = Convert.ToString(product.Id);
        }

        public void AddTypeInfo(IProduct product)
        {
            if (product is GamingPc)
            {
                //add GamingPC specifics
            }
            else if (product is Workstation)
            {
            }
            else if (product is Laptop)
            {
                //txtBoxScreenType.Text = product.ScreenType;
                //txtBoxWeight.Text = $"{Convert.ToString(product.WeightInGrams)} grams";
            }
        }
    }
}