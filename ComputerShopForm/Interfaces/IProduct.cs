﻿namespace ComputerShopForm
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        string ProductSummary { get; set; }
        int Stock { get; set; }
        string ProductImagePath { get; set; }
    }
}