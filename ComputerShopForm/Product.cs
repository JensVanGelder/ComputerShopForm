namespace ComputerShopForm
{
    public abstract class Product : IProduct
    {
        private static int _id = 0;
        private int _myId = 0;

        public int Id
        {
            get { return _myId; }
        }

        public double Price { get; set; }
        public string Name { get; set; }
        public string ProductImagePath { get; set; }
        public string ProductSummary { get; set; }

        private int _stock;
        public int Stock 
        {
            get { return _stock ; }
            set 
                {
                    if (value < 0)
                    {
                        _stock = 0;
                    }
                    else
                    {
                        _stock = value;
                    }
                } 
        }

        public Product(string name, double price, string imagepath, string summary, int stock)
        {
            Price = price;
            Name = name;
            ProductImagePath = imagepath;
            ProductSummary = summary;
            Stock = stock;
            _id++;
            _myId = _id;
        }

        public override string ToString()
        {
            return $"Product:{Name} - ({ProductSummary}) Price: {Price}, Stock: {Stock}";
        }
    }
}