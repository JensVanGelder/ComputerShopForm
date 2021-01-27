using System;
using System.Collections.Generic;
using System.Text;

namespace ScrapbookAlternatief
{
    internal abstract class Product : IProduct
    {
        private int _id { get; set; }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Price { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }

        public Product(string name, double price)
        {
            Price = price;
            Name = name;
        }
    }
}