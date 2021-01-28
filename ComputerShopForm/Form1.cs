using System;
using System.Collections.Generic;
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
                    Id = product.Id,
                };
                flowLayoutPanel1.Controls.Add(usercontrol);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserController1 control = new UserController1();
            List<IProduct> products = control._cart.Shoppinglist;

            string info = "";
            double total = 0;
            foreach (var item in products)
            {
                total += item.Price;
                info += $"{item.Name} Price: {item.Price}";
                info += "\n";
            }
            info += $"\nTotal price: {total} ";
            MessageBox.Show(info);
        }
    }
}