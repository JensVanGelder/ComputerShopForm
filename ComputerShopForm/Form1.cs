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
    public partial class Form1 : Form
    {
        private IProductsRepo productRepo;

        public Form1()
        {
            InitializeComponent();
            productRepo = new ProductsRepo();
            var products = productRepo.CreateProductList();
            GenerateProductControls(products);
        }

        private void GenerateProductControls(IEnumerable<IProduct> products)
        {
            foreach (IProduct product in products)
            {
                UserController1 usercontrol = new UserController1
                {
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductImagePath = product.ProductImagePath,
                };
                flowLayoutPanel1.Controls.Add(usercontrol);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}