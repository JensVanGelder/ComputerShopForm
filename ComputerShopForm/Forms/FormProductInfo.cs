using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormProductInfo : Form
    {
        public List<IProduct> newProducts;
        private FormShop _shop;
        private ProductInfoHandler _handler;

        public string TextName
        {
            get { return txtBoxName.Text; }
            set { txtBoxName.Text = value; }
        }

        public int TextId
        {
            get { return Convert.ToInt32(txtBoxId.Text); }
            set { txtBoxId.Text = value.ToString(); }
        }

        public double TextPrice
        {
            get { return Convert.ToDouble(txtBoxPrice.Text); }
            set { txtBoxPrice.Text = value.ToString(); }
        }

        public string TextImage
        {
            get { return picProductImage.Text; }
            set { picProductImage.Text = value; }
        }

        public string TextSummary
        {
            get { return txtBoxDescription.Text; }
            set { txtBoxDescription.Text = value; }
        }

        public int TextStock
        {
            get { return Convert.ToInt32(txtBoxStock.Text); }
            set { txtBoxStock.Text = value.ToString(); }
        }

        public int TextRam
        {
            get { return Convert.ToInt32(txtBoxRam.Text); }
            set { txtBoxRam.Text = value.ToString(); }
        }

        public string TextMoBo
        {
            get { return txtBoxMoBo.Text; }
            set { txtBoxMoBo.Text = value; }
        }

        public string TextHdd
        {
            get { return txtBoxHdd.Text; }
            set { txtBoxHdd.Text = value; }
        }

        public string TextCpu
        {
            get { return txtBoxCpu.Text; }
            set { txtBoxCpu.Text = value; }
        }

        public string TextPsu
        {
            get { return txtBoxPsu.Text; }
            set { txtBoxPsu.Text = value; }
        }

        public string TextGpu
        {
            get { return txtBoxGpu.Text; }
            set { txtBoxGpu.Text = value; }
        }

        public Performance TextRgb
        {
            get { return Performance.Unknown; }
            set { txtBoxRgb.Text = Performance.Unknown.ToString(); }
        }

        public string TextFortnite
        {
            get { return txtBoxFortnite.Text; }
        }

        public string TextScreenType
        {
            get { return txtBoxScreenType.Text; }
        }

        public string TextScreenSize
        {
            get { return txtBoxScreenSize.Text; }
        }

        public string TextWeight
        {
            get { return txtBoxWeight.Text; }
        }

        public string TextRaid
        {
            get { return txtBoxRaid.Text; }
        }

        public FormProductInfo(IProduct product)
        {
            InitializeComponent();
            this.Text = product.Name;
            SetData(product);
        }

        public FormProductInfo(FormShop shop)
        {
            InitializeComponent();
            _handler = new ProductInfoHandler(this);
            _handler.SetAllTextboxesToWrite();
            btnAdd.Visible = true;
            cmbTypeSelecter.Visible = true;
            cmbTypeSelecter.SelectedIndex = 0;
            lblInfoTitle.Text = "Add Product";
            _shop = shop;
        }

        public void SetData(IProduct product)
        {
            AddComputerInfo(product);
            AddTypeInfo(product);
            txtboxInfo.Text = product.ToString();
            newProducts = new List<IProduct>();
        }

        public void AddComputerInfo(IProduct product)
        {
            var computer = product as Computer;
            picProductImage.Load(computer.ProductImagePath);
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
            switch (product)
            {
                case GamingPc gamingPc:
                    {
                        txtBoxGpu.Text = gamingPc.Gpu;
                        txtBoxFortnite.Text = Convert.ToString(gamingPc.CanPlayFortniteOnHigh);
                        txtBoxRgb.Text = Convert.ToString(gamingPc.RgbPerformance);
                        break;
                    }

                case Workstation workstation:
                    {
                        txtBoxRaid.Text = workstation.RaidType;
                        break;
                    }

                case Laptop laptop:
                    {
                        txtBoxScreenSize.Text = Convert.ToString(laptop.ScreenSize);
                        txtBoxScreenType.Text = laptop.ScreenType;
                        txtBoxWeight.Text = Convert.ToString(laptop.WeightInGrams);
                        break;
                    }

                default:
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_handler.CheckIfEmpty())
            {
                MessageBox.Show("Some required fields are empty");
            }
            else
            {
                switch (cmbTypeSelecter.SelectedIndex)
                {
                    case 0:
                        var gamePc = _handler.CreateGamingPc();
                        _shop._repo.prods.Add(gamePc);
                        break;

                    case 1:
                        var workstation = _handler.CreateWorkstation();
                        _shop._repo.prods.Add(workstation);
                        break;

                    case 2:
                        var laptop = _handler.CreateLaptop();
                        _shop._repo.prods.Add(laptop);
                        break;

                    default:
                        break;
                }
            }
            MessageBox.Show("Product has been added.");
        }

        private void cmbTypeSelecter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTypeSelecter.SelectedIndex)
            {
                case 0:
                    _handler.SetAllTextboxesToWrite();
                    txtBoxRaid.ReadOnly = true;
                    txtBoxRaid.Text = "N/A";
                    txtBoxScreenSize.ReadOnly = true;
                    txtBoxScreenType.ReadOnly = true;
                    txtBoxWeight.ReadOnly = true;
                    break;

                case 1:
                    _handler.SetAllTextboxesToWrite();
                    txtBoxFortnite.ReadOnly = true;
                    txtBoxGpu.ReadOnly = true;
                    txtBoxScreenSize.ReadOnly = true;
                    txtBoxScreenType.ReadOnly = true;
                    txtBoxWeight.ReadOnly = true;
                    txtBoxRgb.ReadOnly = true;
                    break;

                case 2:
                    _handler.SetAllTextboxesToWrite();
                    txtBoxGpu.ReadOnly = true;
                    txtBoxFortnite.ReadOnly = true;
                    txtBoxRaid.ReadOnly = true;
                    txtBoxRgb.ReadOnly = true;
                    break;

                default:
                    break;
            }
        }

        private void txtBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            _handler.CheckInput(e);
        }

        private void txtBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            _handler.CheckInput(e);
        }

        private void txtBoxRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            _handler.CheckInput(e);
        }

        private void txtBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            _handler.CheckInput(e);
        }

        private void txtBoxScreenSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            _handler.CheckInput(e);
        }

        private void txtBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            _handler.CheckInput(e);
        }
    }
}