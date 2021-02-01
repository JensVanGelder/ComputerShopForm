using System.Collections.Generic;

namespace ComputerShopForm
{
    internal interface IFileReader
    {
        List<IProduct> ReadProductListFromFile();
    }
}