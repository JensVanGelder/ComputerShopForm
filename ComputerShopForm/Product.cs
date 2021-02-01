namespace ComputerShopForm
{
    public abstract class Product : IProduct
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }

        public string ProductImagePath { get; set; }

        public string ProductSummary { get; set; }

        private int _stock;

        public int Stock
        {
            get { return _stock; }
            set { _stock = value < 0 ? 0 : value; }
        }

        protected Product(int id, string name, double price, string imagepath, string summary, int stock)
        {
            Id = id;
            Price = price;
            Name = name;
            ProductImagePath = imagepath;
            ProductSummary = summary;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"Product:{Name} - ({ProductSummary}) Price: {Price}, Stock: {Stock}";
        }
    }
}