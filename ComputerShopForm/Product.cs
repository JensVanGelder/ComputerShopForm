namespace ComputerShopForm
{
    public abstract class Product : IProduct
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Price { get; set; }
        public string Name { get; set; }
        public string ProductImagePath { get; set; }
        public string ProductSummary { get; set; }
        public int Stock { get; set; }

        public Product(string name, double price, string imagepath, string summary, int stock)
        {
            Price = price;
            Name = name;
            ProductImagePath = imagepath;
            ProductSummary = summary;
            Stock = stock;
            _id++;
        }

        public override string ToString()
        {
            return $"Product:{Name} - ({ProductSummary}) Price: {Price}, Stock: {Stock}";
        }

        public virtual string GetThisType()
        {
            return "";
        }
    }
}