namespace ComputerShopForm
{
    public class Computer : Product
    {
        public int Ram { get; set; }
        public string MoBo { get; set; }
        public string Hdd { get; set; }
        public string Cpu { get; set; }
        public string Psu { get; set; }

        public Computer(int id, string name, double price, string imagepath, string summary, int stock, int ram, string mobo, string hdd, string cpu, string psu)
            : base(id, name, price, imagepath, summary, stock)
        {
            Ram = ram;
            MoBo = mobo;
            Hdd = hdd;
            Cpu = cpu;
            Psu = psu;
        }

        public override string ToString()
        {
            string add = $"\nRAM IS {Ram}" +
                $"\nMobo: {MoBo}" +
                $"\nHDD: {Hdd}" +
                $"\nCPU: {Cpu}" +
                $"\nPSU: {Psu}";
            return base.ToString() + add;
        }
    }
}