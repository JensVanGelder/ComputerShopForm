using System.Collections.Generic;

namespace ComputerShopForm
{
    internal interface IProductsRepo
    {
        List<IProduct> CreateProductList();
        IProduct GetProduct(int id);
    }
}