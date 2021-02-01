using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShopForm
{
    class CsvFileReader : IFileReader
    {
        public List<IProduct> ReadProductListFromFile() 
        {
            string[] files = Directory.GetFiles(@"Database\","*.csv");
            return new List<IProduct>(); 
        }
    }
}
