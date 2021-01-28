namespace ComputerShopForm
{
    internal interface IProduct
    {
        string Description { get; set; }
        int Id { get; set; }
        int Stock { get; set; }
        string ImagePath { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}