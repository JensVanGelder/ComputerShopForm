using System.Collections.Generic;

namespace ComputerShopForm
{
    public interface IProductsRepo
    {
        List<IProduct> CreateProductList();
        IProduct GetProduct(int id);
    }
}