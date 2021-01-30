namespace ComputerShopForm
{
    public interface IProduct
    {
        string Name { get; set; }
        string ProductImagePath { get; set; }        
        string ProductSummary { get; set; }
        double Price { get; set; }       
        int Stock { get; set; }
        int Id { get; }
    }
}