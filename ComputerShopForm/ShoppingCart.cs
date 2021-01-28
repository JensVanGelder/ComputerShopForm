using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerShopForm
{
    public class ShoppingCart : IShoppingCart,IPriceCalculator
    {
        public List<IProduct> Shoppinglist;
        private static ShoppingCart _cart;

        private ShoppingCart()
        {
            Shoppinglist = new List<IProduct>();
        }

        public void AddProductToCart(IProduct product)
        {
            Shoppinglist.Add(product);
        }

        public static ShoppingCart GetShoppingCart()
        {
            if (_cart == null)
            {
                _cart = new ShoppingCart();
            }
            return _cart;
        }

        public List<IProduct> ShowShoppingCart()
        {
            return Shoppinglist;
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

        public double CalculateTax()
        {
            double tax = 0.21;
            return CalculatePrice() * tax;
        }

        void IShoppingCart.AddProductToCart(IProduct product)
        {
            ((IShoppingCart)_cart).AddProductToCart(product);
        }
    }
}