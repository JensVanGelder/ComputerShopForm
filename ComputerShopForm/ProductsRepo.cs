using System.Collections.Generic;
using System.Linq;

namespace ComputerShopForm
{
    public class ProductsRepo : IProductsRepo
    {
        // string name, double price, string imagepath, string description, int stock, int ram,
        // string mobo, string hdd, string cpu, string psu, string gpu, Performance rgbperformance,
        // bool fortnite

        public List<IProduct> CreateProductList()
        {
            const string PATH = @"C:\Users\michi\OneDrive\Pictures\Saved Pictures\";
            var products = new List<IProduct>
            {
                new Laptop ("HP Oblivion III", 1499,"http://placekitten.com/200/300","A good laptop!",50,8,"AsusRock MAXIMUS Portable", "Seagate LKXII","Intel i5 gen2","HP supplied Laptop PSU",17,"No-glare screen",1245),
                new Laptop("Samsung Chromebook 4",360,"http://placekitten.com/200/300","Entry-level Chromebook",36,4,"ASUS 750JW Laptop Motherboard","Samsung SSD 32GB","Intel Celeron N3350","Samsung supplied Laptop PSU 750W",14,"No-glare screen",1443),
                new Laptop("Lenovo Ideapad 120S - 14",284,"http://placekitten.com/200/300","Entry-level portable computer",24,2,"Lenovo LE254 60NB00M0","Samsung SSD 128GB","Intel Celeron N3350","Lenovo supplied Laptop PSU",14,"No-glare screen",1440),
                new GamingPc ("Razor Extreme", 3500, "http://placekitten.com/200/300", "The wet dream of every gamer!", 6, 32,"Asus ROG STRIX B450-F","SSD 250GB","AMD Ryzen 5 3400G", "Lenovo supplied Hard gamecore PSU","Nvidia GTX1060", Performance.Extreme, true),
                new Workstation("HP Eye of Sauron",1600,"https://laughingsquid.com/wp-content/uploads/2013/04/sauronlamp.jpg","Fly you fools",1,64,"Pure Evil","Lots of memory","His eye","His beautiful rings","Raids the hobbits"),
                new Laptop ("MSI Gaming GF65", 1159,"http://placekitten.com/200/300","A :) laptop!",10,16,"Ja", "512ssd","Intel Core i7","MSI supplied Laptop PSU",15,"No-glare screen",1100),
            };

            return products;
        }

        public IProduct GetProduct(int id)
        {
            List<IProduct> allProducts = CreateProductList();

            // LAMBDA Expression. Return the first object in which the ID property equals user input
            var selectedProduct = allProducts.Where(x => x.Id == id).FirstOrDefault();

            return selectedProduct;
        }
    }
}