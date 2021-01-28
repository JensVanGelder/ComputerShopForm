using System.Collections.Generic;

namespace ComputerShopForm
{
    public interface IShoppingCart
    {
        void AddProductToCart(IProduct product);
    }
}