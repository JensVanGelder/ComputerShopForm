using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShopForm
{
    internal class Laptop : Computer
    {
        public int ScreenSize { get; set; } //in INCH
        public string ScreenType { get; set; }
        public double WeightInGrams { get; set; }

        public Laptop(string name, double price, string imagepath, string description, int stock)
           : base(name, price, imagepath, description, stock)
        {
        }

        public override string ToString()
        {
            string add = $"Your laptop has a screensize of {ScreenSize} inch.\n A nice {ScreenType} and weighs only {WeightInGrams} grams.";
            return base.ToString() + add;
        }
    }
}