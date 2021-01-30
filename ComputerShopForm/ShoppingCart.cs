using System;
using System.Collections.Generic;

namespace ComputerShopForm
{
    [Serializable]
    public class ShoppingCart : IShoppingCart
    {
        public string CartInfo
        {
            get { return $"Order Placed at: {DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")}, Total Price: € {CalculatePrice()}"; }
        }

        public List<IProduct> Shoppinglist { get; set; }

        public static ShoppingCart _cart;
        private IPriceCalculator _priceCalculator;

        public ShoppingCart()
        {
            Shoppinglist = new List<IProduct>();
            _priceCalculator = new PriceCalculator();
        }

        public void AddProductToCart(IProduct product)
        {
            if (product.Stock > 0)
            {
                Shoppinglist.Add(product);
            }
        }

        public void RemoveProductFromCart(string productName)
        {
            foreach (var item in _cart.Shoppinglist)
            {
                if (item.Name == productName)
                {
                    _cart.Shoppinglist.Remove(item);
                    break;
                }
            }
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

        public void ClearCart()
        {
            Shoppinglist.Clear();
        }

        public double CalculatePrice()
        {
            return _priceCalculator.CalculatePrice(Shoppinglist) + _priceCalculator.CalculateWithTax(Shoppinglist);
        }
    }
}