using NUnit.Framework;
using System.Collections.Generic;

namespace ComputerShopForm.Test
{
    internal class ShoppingCartTest
    {
        public IProduct testproduct;
        public ShoppingCart testcart;
        public List<IProduct> testcart2;

        [SetUp]
        public void Setup()
        {
            testcart = new ShoppingCart();
            testcart2 = new List<IProduct>();
            testproduct = new GamingPc("TestComputer", 1, "https://placekitten.com/200/300", "Test description", 1, 0, "TestMOBO", "TestHDD", "TestCPU", "TestPSU", "TestGPU", Performance.Affordable, true);
        }

        [Test]
        public void AddProductToCart_WhenPriceIsCalculated_PriceIsCorrect()
        {
            //ARRANGE
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);

            //ACT
            double priceofcart = testcart.CalculatePrice();

            //ASSERT
            Assert.AreEqual(4.0, priceofcart);
        }
    }
}