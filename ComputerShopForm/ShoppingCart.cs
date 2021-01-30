using System.Collections.Generic;

namespace ComputerShopForm
{
    public class ShoppingCart : IShoppingCart
    {
        public List<IProduct> Shoppinglist;
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
            return _priceCalculator.CalculatePrice(Shoppinglist)+ _priceCalculator.CalculateWithTax(Shoppinglist);
        }
    }
}