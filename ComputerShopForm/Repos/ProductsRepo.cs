using System.Collections.Generic;
using System.Linq;

namespace ComputerShopForm
{
    public class ProductsRepo : IProductsRepo
    {
        // string name, double price, string imagepath, string summary, int stock, int ram, string
        // mobo, string hdd, string cpu, string psu, string gpu, Performance rgbperformance, bool fortnite

        public List<IProduct> CreateProductList()
        {
            //const string PATH = @"C:\Users\michi\OneDrive\Pictures\Saved Pictures\";
            var products = new List<IProduct>
            {
                new Laptop ("HP Envy 15-ep0700nd", 1799,"https://media.s-bol.com/71jRr8MBJmLO/550x451.jpg","Powerhouse in a sleek metallic coat",0,8,"AsusRock MAXIMUS Portable", "Seagate LKXII","Intel i5 gen2","HP supplied Laptop PSU",15,"No-glare screen",1245),
                new Laptop("Samsung Chromebook 4",360,"https://image-us.samsung.com/SamsungUS/home/computing/chromebooks/pdp/121318/01-gallery-hero-521QAB-121318.jpg?$product-details-jpg$","Entry-level Chromebook",36,4,"ASUS 750JW Laptop Motherboard","Samsung SSD 32GB","Intel Core M3 gen.8","Samsung supplied Laptop PSU 750W",14,"No-glare screen",1443),
                new Laptop("Lenovo Ideapad 3 15IIL05",284,"https://media.krefel.be/sys-master/products/8947320750110/600x600.41005451_01.jpg","Entry-level portable computer in Platinum grey",24,2,"Lenovo LE254 60NB00M0","Samsung SSD 128GB","Intel Core i3 - gen10","Lenovo supplied Laptop PSU",15,"No-glare screen",1850),
                new GamingPc ("Corsair CORSAIR ONE a-100", 3399, "https://d2pa5gi5n2e1an.cloudfront.net/global/images/product/desktops/Corsair_CORSAIR_ONE_a100/Corsair_CORSAIR_ONE_a100_L_1.jpg", "The wet dream of every gamer!", 6, 32,"Asus ROG STRIX B450-F","SSD 250GB","AMD Ryzen 9 3900X", "Lenovo supplied Hard gamecore PSU","Nvidia GTX2080Ti", Performance.Extreme, true),
                new Workstation("HP Eye of Sauron",1600,"https://laughingsquid.com/wp-content/uploads/2013/04/sauronlamp.jpg","Fly you fools",1,64,"Pure Evil","Lots of memory","His eye","His beautiful rings","Raids the hobbits"),
                new Laptop ("MSI Gaming GF65", 1159,"http://placekitten.com/200/300","A :) laptop!",10,16,"Ja", "512ssd","Intel Core i7","MSI supplied Laptop PSU",15,"No-glare screen",1100),
                new Laptop ("HP Oblivion III", 1499,"http://placekitten.com/200/300","A good laptop!",50,8,"AsusRock MAXIMUS Portable", "Seagate LKXII","Intel i5 gen2","HP supplied Laptop PSU",17,"No-glare screen",1245),
                new Laptop("Samsung Chromebook 4",360,"http://placekitten.com/200/300","Entry-level Chromebook",36,4,"ASUS 750JW Laptop Motherboard","Samsung SSD 32GB","Intel Celeron N3350","Samsung supplied Laptop PSU 750W",14,"No-glare screen",1443),
                new Laptop("Lenovo Ideapad 120S - 14",284,"http://placekitten.com/200/300","Entry-level portable computer",24,2,"Lenovo LE254 60NB00M0","Samsung SSD 128GB","Intel Celeron N3350","Lenovo supplied Laptop PSU",14,"No-glare screen",1440),
                new GamingPc ("Razor Extreme", 3500, "http://placekitten.com/200/300", "The wet dream of every gamer!", 6, 32,"Asus ROG STRIX B450-F","SSD 250GB","AMD Ryzen 5 3400G", "Lenovo supplied Hard gamecore PSU","Nvidia GTX1060", Performance.Extreme, true),
                new Workstation("HP Eye of Sauron",1600,"https://laughingsquid.com/wp-content/uploads/2013/04/sauronlamp.jpg","Fly you fools",1,64,"Pure Evil","Lots of memory","His eye","His beautiful rings","Raids the hobbits"),
                new Laptop ("MSI Gaming GF65", 1159,"http://placekitten.com/200/300","A :) laptop!",10,16,"Ja", "512ssd","Intel Core i7","MSI supplied Laptop PSU",15,"No-glare screen",1100),
                new Laptop ("HP Oblivion III", 1499,"http://placekitten.com/200/300","A good laptop!",50,8,"AsusRock MAXIMUS Portable", "Seagate LKXII","Intel i5 gen2","HP supplied Laptop PSU",17,"No-glare screen",1245),
                new Laptop("Samsung Chromebook 4",360,"http://placekitten.com/200/300","Entry-level Chromebook",36,4,"ASUS 750JW Laptop Motherboard","Samsung SSD 32GB","Intel Celeron N3350","Samsung supplied Laptop PSU 750W",14,"No-glare screen",1443),
                new Laptop("Lenovo Ideapad 120S - 14",284,"https://www.lenovo.com/medias/lenovo-laptop-ideapad-3-17-intel-subseries-gallery-2.jpg?context=bWFzdGVyfHJvb3R8Mjc3MjJ8aW1hZ2UvanBnfGgyZi9oOWYvMTA3NDQ5NjgwODU1MzQuanBnfDkzYjgzMjNlZWFmYjk3ODUxMTQxMzY2NzgwNGZhZTUzMTljM2IzY2Y1Y2I0ZmIxYTA4ODFiZGVjNTY3YzJhZGM","Entry-level portable computer",24,2,"Lenovo LE254 60NB00M0","Samsung SSD 128GB","Intel Celeron N3350","Lenovo supplied Laptop PSU",14,"No-glare screen",1440),
                new GamingPc ("Razor Extreme", 3500, "http://placekitten.com/200/300", "The wet dream of every gamer!", 6, 32,"Asus ROG STRIX B450-F","SSD 250GB","AMD Ryzen 5 3400G", "Lenovo supplied Hard gamecore PSU","Nvidia GTX1060", Performance.Extreme, true),
                new Workstation("HP Eye of Sauron",1600,"https://laughingsquid.com/wp-content/uploads/2013/04/sauronlamp.jpg","Fly you fools",1,64,"Pure Evil","Lots of memory","His eye","His beautiful rings","Raids the hobbits"),
                new Laptop ("MSI Gaming GF65", 1159,"https://static.bhphoto.com/images/images2500x2500/1593628543_1571736.jpg","Thin gaming laptop for portable entertainment",10,16,"Ja", "512ssd","Intel Core i5","MSI supplied Laptop PSU",15,"No-glare screen",1250),
                new GamingPc ("MSI MAG Codex 5", 1599, "https://cyberport.scene7.com/is/image/cyberport/201014144453900301900087O?$Zoom_1000$", "The wet dream of every gamer!", 6, 32,"Asus ROG STRIX B450-F","SSD 250GB","AMD Ryzen 5 3400G", "Lenovo supplied Hard gamecore PSU","Nvidia GTX1060", Performance.Extreme, true),
            };

            return products;
        }

        public IProduct GetProduct(string name)
        {
            List<IProduct> allProducts = CreateProductList();

            // LAMBDA Expression. Return the first object in which the Name property equals user input
            var selectedProduct = allProducts.Where(x => x.Name == name).FirstOrDefault();

            return selectedProduct;
        }
    }
}