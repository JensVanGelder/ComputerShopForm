using NUnit.Framework;
using System.Collections.Generic;

namespace ComputerShopForm
{
    internal class PriceCalculatorTest
    {
        private PriceCalculator calc;
        private List<IProduct> products;

        [SetUp]
        public void Setup()
        {
            products = new List<IProduct>();
            calc = new PriceCalculator();
            products.Add(new Laptop("HP Oblivion III", 1499.99, "http://placekitten.com/200/300", "A good laptop!", 0, 8, "AsusRock MAXIMUS Portable", "Seagate LKXII", "Intel i5 gen2", "HP supplied Laptop PSU", 17, "No-glare screen", 1245));
            products.Add(new Laptop("HP Oblivion III", 1499.99, "http://placekitten.com/200/300", "A good laptop!", 0, 8, "AsusRock MAXIMUS Portable", "Seagate LKXII", "Intel i5 gen2", "HP supplied Laptop PSU", 17, "No-glare screen", 1245));
            products.Add(new Laptop("HP Oblivion III", 1499.99, "http://placekitten.com/200/300", "A good laptop!", 0, 8, "AsusRock MAXIMUS Portable", "Seagate LKXII", "Intel i5 gen2", "HP supplied Laptop PSU", 17, "No-glare screen", 1245));
        }

        [TestCase(5.0, 3.0, 2.0, 10.0)]
        [TestCase(0, 5, 5, 10.0)]
        public void CalculatePrice_WhenCalled_ReturnsCorrectValue(double price1, double price2, double price3, double expectedOutcome)
        {
            products[0].Price = price1;
            products[1].Price = price2;
            products[2].Price = price3;

            double price = calc.CalculatePrice(products);
            Assert.AreEqual(expectedOutcome, price);
        }

        [TestCase(5, 5, 5, 15 * 0.21)]
        public void CalculateWithTax_WhenCalled_ReturnsCalculatePriceTimesTax(double price1, double price2, double price3, double expectedOutcome)
        {
            products[0].Price = price1;
            products[1].Price = price2;
            products[2].Price = price3;
            double price = calc.CalculateTax(products);
            Assert.AreEqual(expectedOutcome, price);
        }
    }
}