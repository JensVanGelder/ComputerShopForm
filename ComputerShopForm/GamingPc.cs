﻿namespace ComputerShopForm
{
    public class GamingPc : Computer
    {
        public string Gpu { get; set; }

        public Performance RgbPerformance { get; set; }

        public bool CanPlayFortniteOnHigh { get; set; }

        public GamingPc(int id, string name, double price, string imagepath, string summary, int stock, int ram, string mobo, string hdd, string cpu, string psu, string gpu, Performance rgbperformance, bool fortnite)
            : base(id, name, price, imagepath, summary, stock, ram, mobo, hdd, cpu, psu)
        {
            Gpu = gpu;
            RgbPerformance = rgbperformance;
            CanPlayFortniteOnHigh = fortnite;
        }

        public override string ToString()
        {
            string fortnite = CanPlayFortniteOnHigh ? "Fortnite(60fps+)" : "Fortnite(30fps+)";
            string add = $"Has GPU :{Gpu}, {fortnite}";
            return base.ToString() + add;
        }
    }
}