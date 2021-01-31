﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class FormShop : Form
    {
        private IProductsRepo _repo;
        private IShoppingCart _cart;
        private IList<UserControlShop> _controls;
        public List<IProduct> productList;

        public FormShop()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            _repo = new ProductsRepo();
            _cart = ShoppingCart.GetShoppingCart();
            _controls = new List<UserControlShop>();

            productList = _repo.CreateProductList();
            GenerateProductControls(productList);
        }

        private void GenerateProductControls(IEnumerable<IProduct> products)
        {
            foreach (IProduct product in products)
            {
                UserControlShop usercontrol = new UserControlShop
                {
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductImagePath = product.ProductImagePath,
                    ProductSummary = product.ProductSummary,
                    ProductStock = product.Stock,
                    SameDayDelivery = true,
                    Id = product.Id,
                };

                usercontrol.AddToCartButtonClicked += AddToCartClickedInUserControl;
                _controls.Add(usercontrol);
            }
            flowLayoutPanel1.Controls.AddRange(_controls.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormShoppingCart cart = new FormShoppingCart();
            cart.Show();
        }

        private void AddToCartClickedInUserControl(object sender, EventArgs e)
        {
            var userControl = sender as UserControlShop;
            var product = _repo.GetProduct(userControl.ProductName);
            _cart.AddProductToCart(product);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowLayoutPanel1.Controls)
            {
                if (control.ProductName == "HP Oblivion III")
                {
                    control.Visible = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (UserControlShop control in flowLayoutPanel1.Controls)
            {
                control.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var selectedControls = _controls.Where(x => x.ProductName.ToLower() == textBox1.Text.ToLower()).Select(y => y.Visible = true).ToList();
            //_controls.Where(x => x.ProductName.ToLower() == textBox1.Text.ToLower()).Select(y=>y.Visible=true);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                foreach (UserControlShop control in flowLayoutPanel1.Controls)
                {
                    control.Visible = false;
                    string input = textBox1.Text.ToLower();
                    if (ProductName.ToLower().Contains(input)||control.ProductSummary.ToLower().Contains(input))
                    {
                        control.Visible = true;
                    }
                }
            }
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            FormShoppingCart cart = new FormShoppingCart();
            cart.Show();
        }
    }
}