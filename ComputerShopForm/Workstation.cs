namespace ComputerShopForm
{
    public class Workstation : Computer
    {
        public string RaidType { get; set; }

        public Workstation(int id, string name, double price, string imagepath, string description, int stock, int ram, string mobo, string hdd, string cpu, string psu, string raidType)
               : base(id, name, price, imagepath, description, stock, ram, mobo, hdd, cpu, psu)
        {
            RaidType = raidType;
        }

        public override string ToString()
        {
            string add = $"Your workstation is equipped with {RaidType}";
            return base.ToString() + add;
        }
    }
}