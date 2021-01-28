using System;
using System.Linq;
using System.Windows.Forms;

namespace ComputerShopForm
{
    public partial class CartControl : UserControl
    {
        public ShoppingCart _cart;
        public IProductsRepo _repo;

        public CartControl()
        {
            InitializeComponent();
            _cart = ShoppingCart.GetShoppingCart();
            _repo = new ProductsRepo();
        }

        public int Id { get; set; }

        public string ProductName
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
            set { lblPrice.Text = $"€ {value}"; }
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
                    pictureBox1.ImageLocation = _productImagePath;
                    pictureBox1.Load(_productImagePath);
                }
            }
        }

        public string CountOccurenceOfValue(int valueToFind)
        {
            string temp = "";
            //var query = _cart.Shoppinglist.SelectMany(x => x.Name)
            //                .GroupBy(s => s)
            //                .Select(g => new { Name = g.Name, Count = g.Count() });

            //foreach (var result in query)
            //{
            //    temp+= $"Name: {result.Name}, Count: {result.Count}\n";
            //}
            //return temp;

            var q = from x in _cart.Shoppinglist
                    group x by x.Name into g
                    let count = g.Count()
                    orderby count descending
                    select new { Name = g.Key, Count = count, ID = g.First().Id };

            foreach (var x in q)
            {
                temp += ("\n Name: " + x.Name + " ID: " + x.ID + "Count: " + x.Count);
            }
            return temp;
        }
    }
}