using System;
using System.Collections.Generic;
using System.Linq;

namespace ComputerShopForm
{
    [Serializable]
    public class ShoppingCart : IShoppingCart
    {
        public List<IProduct> ShoppingList { get; set; }

        private static ShoppingCart _cart;
        private IPriceCalculator _priceCalculator;

        public ShoppingCart()
        {
            ShoppingList = new List<IProduct>();
            _priceCalculator = new PriceCalculator();
        }

        public string CartInfo
        {
            get { return $"Order Placed at: {DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")}, Total Price: € {GetPrice()}"; }
        }

        public void AddProductToCart(IProduct product)
        {
            if (product.Stock > 0)
            {
                ShoppingList.Add(product);
            }
        }

        public void RemoveProductFromCart(string productName)
        {
            foreach (var item in _cart.ShoppingList.Where(item => item.Name == productName))
            {
                _cart.ShoppingList.Remove(item);
                break;
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
            return ShoppingList;
        }

        public void ClearCart()
        {
            ShoppingList.Clear();
        }

        public double GetPriceWithTax()
        {
            return Math.Round(_priceCalculator.CalculatePrice(ShoppingList) + _priceCalculator.CalculateTax(ShoppingList), 2);
        }

        public double GetPrice()
        {
            return Math.Round(_priceCalculator.CalculatePrice(ShoppingList), 2);
        }
    }
}