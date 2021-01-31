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
        }

        public void AddComputerInfo(IProduct product)
        {
            if (product is Computer computer)
            {
                pictureBoxProductInfo.Load(computer.ProductImagePath);
                txtBoxName.Text = computer.Name;
                txtBoxPsu.Text = computer.PSU;
            }

            txtBoxPrice.Text = Convert.ToString(product.Price);
            txtBoxDescription.Text = product.ProductSummary;
            txtBoxId.Text = Convert.ToString(product.Id);
        }

        public void AddTypeInfo(IProduct product)
        {
            switch (product)
            {
                case GamingPc pc:
                {
                    txtBoxCpu.Text = pc.CPU;
                    txtBoxHdd.Text = pc.HDD;
                    txtBoxMoBo.Text = pc.MoBo;
                    break;
                }
                case Workstation workstation:
                {
                    break;
                }
                case Laptop laptop:
                {
                    txtBoxScreenType.Text = laptop.ScreenType;
                    txtBoxWeight.Text = $@"{Convert.ToString(laptop.WeightInGrams)} grams";
                    break;
                }
            }
        }
    }
}