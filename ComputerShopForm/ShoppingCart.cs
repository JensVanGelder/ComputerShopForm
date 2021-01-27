using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShopForm
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

        public string ShowShoppingCart()
        {
            string output = "";
            foreach (IProduct product in Shoppinglist)
            {
                output += "\n" + (product.Name);
                //Console.WriteLine(CalculatePrice());

                product.ToString();
            }
            return output;
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