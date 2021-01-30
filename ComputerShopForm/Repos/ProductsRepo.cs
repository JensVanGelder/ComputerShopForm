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
                new Workstation("Microsoft Surface Studio 2",3493.97,"https://assets.mmsrg.com/isr/166325/c1/-/pixelboxx-mss-80160653/mobile_786_587_png/MICROSOFT-Surface-Studio-2-28%22-Intel-Core-i7-7820HQ-1-TB-32-GB-RAM-%28LAK-00016%29","The ultimate creators machine.",5,32,"Microsoft BGBB9-K Desktop Motherboard","Samsung EVO SSD 512GB x4","Intel® Core™ i7-7820HQ-processor","Microsoft PSU","RAID-1"),
                new GamingPc ("Corsair CORSAIR ONE a-100", 3399, "https://d2pa5gi5n2e1an.cloudfront.net/global/images/product/desktops/Corsair_CORSAIR_ONE_a100/Corsair_CORSAIR_ONE_a100_L_1.jpg", "The wet dream of every gamer!", 6, 32,"Asus ROG STRIX B450-F","SSD 250GB","AMD Ryzen 9 3900X", "Lenovo supplied Hard gamecore PSU","Nvidia GTX2080Ti", Performance.Extreme, true),
                new Laptop("HP EliteBook G6 840",1600,"https://www8.hp.com/be/nl/images/HP_EliteBook_800_Series_image3_tcm109_2539043_tcm109_2539053_tcm109-2539043.png","A well-known versatile notebook.",2,16,"Gigabyte Aorus AX370 EB 5","SG -SSD 512GB","Intel i5 gen.6","HP Laptop PSU",14,"TN - matte",1333),
                new Laptop ("MSI Gaming GF63 10SCR-1012BE", 1012,"https://media.s-bol.com/gpzExW9GnDwl/550x354.jpg","Powerful MSI Laptop for gaming and graphical design",10,8,"Ja", "WDHD - 512GB SSD","Intel Core i5","MSI supplied Laptop PSU",15,"TN - No-glare screen",1100),
                new Laptop ("ASUS ROG Strix G17 - g713qm", 1599,"https://geekculture.co/wp-content/uploads/2021/01/ROG-Strix-Scar-15.jpg","Designed for gaming on the mov",50,8,"AsusRock MAXIMUS Gaming rev.7 Portable", "WD 512GB SSD","Intel i7 gen4","AsusRock PSU",17,"TN - No-glare screen",1445),
                new Laptop("GIGABYTE AERO 17 HDR KB",1899,"https://m.alternate.be/p/600x600/p/GIGABYTE_AERO_17_HDR_KB__17_3___laptop@@pl8gzb05_30.jpg","Compact but very powerful.",36,16,"GIGABYTE AERO 750JW Laptop Motherboard","Samsung SSD 512GB","Intel® Core™ i7-10875H","AERO PSU 750W",15,"IPS - No-glare screen",1443),
                new Laptop("Microsoft Surface Laptop 3",1349,"https://media.s-bol.com/mQjG28jpWNLA/550x356.jpg","Thin and light, improved performance and longer lasting battery. ",10,8,"MSMB13479KN-M0","Samsung EVO5 SSD 256GB","AMD Ryzen 5","MS Laptop PSU",15,"IPS - nonmatte Touchscreen",1512),
                new GamingPc ("ACER Predator Orion 5000 (615S I910-14GLR)", 3299, "https://assets.mmsrg.com/isr/166325/c1/-/ASSET_MMS_76663675/fee_786_587_png/ACER-Predator-Orion-5000-%28615S-I910-14GLR%29", "High-end Gaming workhorse.", 4, 32,"ASROCK MAXIMUS Gaming Rev.7","1TB HDD + SSD 512GB","Intel Core i9-10900K", "ACER supplied Hard gamecore PSU","NVIDIA GeForce RTX 2080 Ti", Performance.Extreme, true),
                new Workstation("HP Eye of Sauron",1600,"https://laughingsquid.com/wp-content/uploads/2013/04/sauronlamp.jpg","Fly you fools",1,64,"Pure Evil","Lots of memory","His eye","His beautiful rings","Raids the hobbits"),
                new Laptop ("MEDION ERAZER", 999,"https://media.s-bol.com/7pjG9oYOO5Rr/550x373.jpg","Unleash your inner gamer.",4,16,"MED10300H", "WD 512GB SSD","Intel Core i5","Standard Laptop PSU",15,"TN No-glare screen",1540),
                new Laptop ("HP Envy 15 III-ep0098nr", 1499,"https://media.s-bol.com/71jRr8MBJmLO/550x451.jpg","Powerful precision in a familiar jacket",50,8,"Intel HM470", "Samsung EVO-R 512GB SSD","Intel Core i7-10750H","HP supplied Laptop PSU",15,"No-glare screen",1245),
                new Laptop("Lenovo Ideapad 120S - 14",284,"https://www.lenovo.com/medias/lenovo-laptop-ideapad-3-17-intel-subseries-gallery-2.jpg?context=bWFzdGVyfHJvb3R8Mjc3MjJ8aW1hZ2UvanBnfGgyZi9oOWYvMTA3NDQ5NjgwODU1MzQuanBnfDkzYjgzMjNlZWFmYjk3ODUxMTQxMzY2NzgwNGZhZTUzMTljM2IzY2Y1Y2I0ZmIxYTA4ODFiZGVjNTY3YzJhZGM","Entry-level portable computer",24,2,"Lenovo LE254 60NB00M0","Samsung SSD 128GB","Intel Celeron N3350","Lenovo supplied Laptop PSU",14,"IPS No-glare screen",1440),
                new Workstation("Acer Veriton mini N4670GT",1699,"https://image.coolblue.nl/max/500x500/products/1450793","With the Acer Veriton Mini Workstation N4670GT - DT.VU1EH.002, you don't have to choose between powerful and compact.",2,32,"Acer Veriton X275 Desktop Motherboard","Samsung EVO SSD 512GB x2","Intel Core i9","1500W Acer PSU","RAID-1"),
                new Laptop ("MSI Gaming GF65", 1159,"https://static.bhphoto.com/images/images2500x2500/1593628543_1571736.jpg","Thin gaming laptop for portable entertainment",10,16,"Ja", "512ssd","Intel Core i5","MSI supplied Laptop PSU",15,"OLED No-glare screen",1250),
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