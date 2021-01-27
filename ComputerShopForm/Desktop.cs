using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerShopForm
{
    internal class Desktop : Product
    {
        //public List<Part> parts;
        public string MOBO { get; set; }

        public string GPU { get; set; }
        public string PSU { get; set; }

        public Desktop(string name, double price) : base(name, price)

        {
        }
    }
}