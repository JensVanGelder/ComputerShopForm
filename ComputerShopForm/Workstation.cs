using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShopForm
{//string hdd, string cpu, string psu, string gpu, Performance rgbperformance, bool fortnite)
    internal class Workstation : Computer
    {
        public string Raidtype { get; set; }

        public Workstation(string name, double price, string imagepath, string description, int stock, int ram, string hdd, string cpu, string psu)
               : base(name, price, imagepath, description, stock, ram, hdd, cpu, psu)
        {
        }

        public override string ToString()
        {
            string add = $"Your workstation is equipped with {Raidtype}";
            return base.ToString() + add;
        }
    }
}