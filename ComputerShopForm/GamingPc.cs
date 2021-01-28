using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShopForm
{
    internal class GamingPc : Computer
    {
        public string GPU { get; set; }
        public Performance RgbPerformance { get; set; }

        public bool CanPlayFortniteOnHigh { get; set; }

        public GamingPc(string name, double price, string imagepath, string description, int stock, int ram, string mobo, string hdd, string cpu, string psu, string gpu, Performance rgbperformance, bool fortnite)
            : base(name, price, imagepath, description, stock, ram, mobo, hdd, cpu, psu)
        {
            GPU = gpu;
            RgbPerformance = rgbperformance;
            CanPlayFortniteOnHigh = fortnite;
        }

        public override string ToString()
        {
            string fortnite = CanPlayFortniteOnHigh ? "Fortnite(60fps+)" : "Fortnite(30fps+)";
            string add = $"Has GPU :{GPU}, {fortnite}";
            return base.ToString() + add;
        }
    }
}