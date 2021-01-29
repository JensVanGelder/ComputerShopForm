using System.Collections.Generic;

namespace ComputerShopForm
{
    public class ShoppingCart : IShoppingCart, IPriceCalculator
    {
        public List<IProduct> Shoppinglist;
        public static ShoppingCart _cart;

        public ShoppingCart()
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

        public double CalculateWithTax()
        {
            double tax = 1.21;
            return CalculatePrice()  *tax;
        }
        public void ClearCart()
        {
            Shoppinglist.Clear();
        }
    }
}