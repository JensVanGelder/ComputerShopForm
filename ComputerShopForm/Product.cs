using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerShopForm
{
    internal abstract class Product : IProduct
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Price { get; set; }
        public string Name { get; set; }
        public string ProductImagePath { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, string imagepath, string description, int stock)
        {
            Price = price;
            Name = name;
            ProductImagePath = imagepath;
            Description = description;
            Stock = stock;
            _id++;
        }

        public override string ToString()
        {
            return $"Product:{Name} - ({Description}) Price: {Price}, Stock: {Stock}";
        }
    }
}