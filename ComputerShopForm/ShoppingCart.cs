using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrapbookAlternatief
{
    internal class ShoppingCart
    {
        public List<IProduct> Shoppinglist { get; set; }

        public ShoppingCart()
        {
            Shoppinglist = new List<IProduct>();
        }

        public void AddProductToCart(IProduct product)
        {
            Shoppinglist.Add(product);
        }

        public void ShowShoppingCart()
        {
            foreach (IProduct product in Shoppinglist)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(CalculatePrice());
                product.ToString();
            }
        }

        public double CalculatePrice()
        {
            double price = new double();
            foreach (IProduct product in Shoppinglist)
            {
                price += product.Price;
            }

            return price;
        }
    }
}