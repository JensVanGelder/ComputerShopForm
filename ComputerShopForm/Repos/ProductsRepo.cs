using System.Collections.Generic;
using System.Linq;

namespace ComputerShopForm
{
    public class ProductsRepo : IProductsRepo
    {
        public List<IProduct> prods;
        public List<IProduct> CreateProductList()
        {
            var products = new List<IProduct>
            {
                new Laptop (1,"HP Envy 15-ep0700nd", 1799,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/HP+Envy+15+edit.png","Powerhouse in a sleek metallic coat",0,8,"AsusRock MAXIMUS Portable", "Seagate LKXII","Intel i5 gen2","HP supplied Laptop PSU",15,"No-glare screen",1245),
                new Laptop(2,"Samsung Chromebook 4",360,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/Samsung+Chromebook+4+EDIT.png","Entry-level Chromebook",36,4,"ASUS 750JW Laptop Motherboard","Samsung SSD 32GB","Intel Core M3 gen.8","Samsung supplied Laptop PSU 750W",14,"No-glare screen",1443),
                new Laptop(3,"Lenovo Ideapad 3 15IIL05",284,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/Lenovo+Ideapad+3+edit1.png","Entry-level portable computer in Platinum grey",24,2,"Lenovo LE254 60NB00M0","Samsung SSD 128GB","Intel Core i3 - gen10","Lenovo supplied Laptop PSU",15,"No-glare screen",1850),
                new Workstation(4,"Microsoft Surface Studio 2",3493.97,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/surface-studio-2-microsoft.png","The ultimate creators machine.",5,32,"Microsoft BGBB9-K Desktop Motherboard","Samsung EVO SSD 512GB x4","Intel® Core™ i7-7820HQ-processor","Microsoft PSU","RAID-1"),
                new GamingPc (5, "Corsair CORSAIR ONE a-100", 3399, "https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/Corsair_CORSAIR_ONE_a100_L_1+EDIT.png", "The wet dream of every gamer!", 6, 32,"Asus ROG STRIX B450-F","SSD 250GB","AMD Ryzen 9 3900X", "Lenovo supplied Hard gamecore PSU","Nvidia GTX2080Ti", Performance.Extreme, true),
                new Laptop(6, "HP EliteBook G6 840",1600,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/HP+Elitebook+EDIT.png","A well-known versatile notebook.",2,16,"Gigabyte Aorus AX370 EB 5","SG -SSD 512GB","Intel i5 gen.6","HP Laptop PSU",14,"TN - matte",1333),
                new Laptop (7,"MSI Gaming GF63 10SCR-1012BE", 1012,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/MSI+Gaming+GF63+10SCR-1012BEedit1.png","Powerful MSI Laptop for gaming and graphical design",10,8,"Ja", "WDHD - 512GB SSD","Intel Core i5","MSI supplied Laptop PSU",15,"TN - No-glare screen",1100),
                new Laptop (8,"ASUS ROG Strix G17 - g713qm", 1599,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/ROG-Strix-Scar-15+EDIT.png","Designed for gaming on the mov",50,8,"AsusRock MAXIMUS Gaming rev.7 Portable", "WD 512GB SSD","Intel i7 gen4","AsusRock PSU",17,"TN - No-glare screen",1445),
                new Laptop(9, "GIGABYTE AERO 17 HDR KB",1899,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/GIGABYTE_AERO_17_edit1.png","Compact but very powerful.",36,16,"GIGABYTE AERO 750JW Laptop Motherboard","Samsung SSD 512GB","Intel® Core™ i7-10875H","AERO PSU 750W",15,"IPS - No-glare screen",1443),
                new Laptop(10, "Microsoft Surface Laptop 3",1349,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/Microsoft+Surface+Laptop+3+edit1.png","Thin and light, improved performance and longer lasting battery. ",10,8,"MSMB13479KN-M0","Samsung EVO5 SSD 256GB","AMD Ryzen 5","MS Laptop PSU",15,"IPS - nonmatte Touchscreen",1512),
                new GamingPc (11,"ACER Predator Orion 5000 (615S I910-14GLR)", 3299, "https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/ACER+Predator+Orion+EDIT.png", "High-end Gaming workhorse.", 4, 32,"ASROCK MAXIMUS Gaming Rev.7","1TB HDD + SSD 512GB","Intel Core i9-10900K", "ACER supplied Hard gamecore PSU","NVIDIA GeForce RTX 2080 Ti", Performance.Extreme, true),
                new Workstation(12,"HP Eye of Sauron",1600,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/THE+EYE+edits.png","Fly you fools",1,64,"Pure Evil","Lots of memory","His eye","His beautiful rings","Raids the hobbits"),
                new Laptop (13,"MEDION ERAZER", 999,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/Medion+Erazer+edit1.png","Unleash your inner gamer.",4,16,"MED10300H", "WD 512GB SSD","Intel Core i5","Standard Laptop PSU",15,"TN No-glare screen",1540),
                new Laptop (14,"HP Envy 15 III-ep0098nr", 1499,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/HP+Envy+15+edit.png","Powerful precision in a familiar jacket",50,8,"Intel HM470", "Samsung EVO-R 512GB SSD","Intel Core i7-10750H","HP supplied Laptop PSU",15,"No-glare screen",1245),
                new Laptop(15,"Lenovo Ideapad 120S - 14",284,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/Lenovo+Ideapad+3+edit1.png","Entry-level portable computer",24,2,"Lenovo LE254 60NB00M0","Samsung SSD 128GB","Intel Celeron N3350","Lenovo supplied Laptop PSU",14,"IPS No-glare screen",1440),
                new Workstation(16,"Acer Veriton mini N4670GT",1699,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/Acer+Veriton+EDIT.png","With the Acer Veriton Mini Workstation N4670GT - DT.VU1EH.002, you don't have to choose between powerful and compact.",2,32,"Acer Veriton X275 Desktop Motherboard","Samsung EVO SSD 512GB x2","Intel Core i9","1500W Acer PSU","RAID-1"),
                new Laptop (17,"MSI Gaming GF65", 1159,"https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/MSI+Gaming+GD65edit1.png","Thin gaming laptop for portable entertainment",10,16,"Ja", "512ssd","Intel Core i5","MSI supplied Laptop PSU",15,"OLED No-glare screen",1250),
                new GamingPc (18, "MSI MAG Codex 5", 1599, "https://bucketcomputershopform.s3.eu-central-1.amazonaws.com/MSI+MAG+Codex+5+EDIT.png", "The wet dream of every gamer!", 6, 32,"Asus ROG STRIX B450-F","SSD 250GB","AMD Ryzen 5 3400G", "Lenovo supplied Hard gamecore PSU","Nvidia GTX1060", Performance.Extreme, true),
            };
            return products;
        }

        public IProduct GetProduct(int id, List<IProduct> products)
        {
            var selectedProduct = products.FirstOrDefault(x => x.Id == id);
            return selectedProduct;
        }
    }
}