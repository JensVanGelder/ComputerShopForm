using System.Collections.Generic;

namespace ComputerShopForm
{
    interface IFileReader
    {
        List<IProduct> ReadProductListFromFile();
    }
}