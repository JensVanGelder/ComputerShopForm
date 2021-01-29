namespace ComputerShopForm
{
    public class Computer : Product
    {
        public int Ram { get; set; }
        public string MoBo { get; set; }
        public string HDD { get; set; }
        public string CPU { get; set; }
        public string PSU { get; set; }

        public Computer(string name, double price, string imagepath, string summary, int stock, int ram, string mobo, string hdd, string cpu, string psu)
            : base(name, price, imagepath, summary, stock)
        {
            Ram = ram;
            MoBo = mobo;
            HDD = hdd;
            CPU = cpu;
            PSU = psu;
        }

        public override string ToString()
        {
            string add = $"\nRAM IS {Ram}";
            return base.ToString() + add;
        }
    }
}