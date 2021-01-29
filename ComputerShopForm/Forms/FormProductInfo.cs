using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormProductInfo : Form
    {
        private IProductsRepo _repo;
        public List<IProduct> _productinfolist;

        public FormProductInfo(IProduct product)
        {
            InitializeComponent();
            _repo = new ProductsRepo();
            _productinfolist = _repo.CreateProductList();
            SetData(product);
        }

        public void SetData(IProduct product)
        {
            var computer = product as Computer;
            pictureBoxProductInfo.Load(product.ProductImagePath);
            txtBoxName.Text = product.Name;
            txtBoxPsu.Text = computer.PSU;
            txtBoxPrice.Text = Convert.ToString(product.Price);
            txtBoxDescription.Text = product.ProductSummary;
            txtBoxId.Text = Convert.ToString(product.Id);

            if (product is GamingPc)
            {
                var temp = product as GamingPc;
                txtBoxCpu.Text = temp.CPU;
                txtBoxHdd.Text = temp.HDD;
                txtBoxMoBo.Text = temp.MoBo;
            }
            else if (product is Workstation)
            {
                var temp = product as Workstation;
            }
            else if (product is Laptop)
            {
                var temp = product as Laptop;
                txtBoxScreenType.Text = temp.ScreenType;
                txtBoxWeight.Text = Convert.ToString(temp.WeightInGrams);
            }

            //txtboxInfo.Text = product.ToString();
        }
    }
}