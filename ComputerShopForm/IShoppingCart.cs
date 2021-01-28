using System.Collections.Generic;

namespace ComputerShopForm
{
    internal interface IShoppingCart
    {
        List<IProduct> Shoppinglist { get; set; }

        void AddProductToCart(IProduct product);
        List<IProduct> ShowShoppingCart();
    }
}