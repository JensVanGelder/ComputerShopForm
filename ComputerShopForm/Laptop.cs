namespace ComputerShopForm
{
    public class Laptop : Computer
    {
        public int ScreenSize { get; set; } //in INCH
        public string ScreenType { get; set; }
        public double WeightInGrams { get; set; }

        public Laptop(int id, string name, double price, string imagepath, string summary, int stock, int ram, string mobo, string hdd, string cpu, string psu, int screensize, string screentype, double weightingrams)
           : base(id, name, price, imagepath, summary, stock, ram, mobo, hdd, cpu, psu)
        {
            ScreenSize = screensize;
            ScreenType = screentype;
            WeightInGrams = weightingrams;
        }

        public override string ToString()
        {
            string add = $"Your laptop has a screensize of {ScreenSize} inch.\n A nice {ScreenType} and weighs only {WeightInGrams} grams.";
            return base.ToString() + add;
        }
    }
}