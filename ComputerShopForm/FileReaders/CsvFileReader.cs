using System.Collections.Generic;
using System.IO;

namespace ComputerShopForm
{
    internal class CsvFileReader : IFileReader
    {
        public List<IProduct> ReadProductListFromFile()
        {
            string[] files = Directory.GetFiles(@"Database\", "*.csv");
            return new List<IProduct>();
        }
    }
}