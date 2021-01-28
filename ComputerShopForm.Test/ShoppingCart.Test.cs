using NUnit.Framework;
using ComputerShopForm;
using System.Collections.Generic;
using System.IO;
using System;

namespace ComputerShopForm.Test
{
    internal class ShoppingCartTest
    {
        public IPriceCalculator calc;
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
        public void ShoppingCart_WhenPriceIsCalculated_PriceIsCorrect()
        {
            //ARRANGE
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);
            testcart.AddProductToCart(testproduct);

            testcart2.Add(testproduct);
            testcart2.Add(testproduct);
            testcart2.Add(testproduct);
            testcart2.Add(testproduct);

            //ACT
            //int[] testarray;
            double priceoflist = new double();

            foreach (IProduct testproduct in testcart2)
            {
                priceoflist += testproduct.Price;
            }

            double priceofcart = testcart.CalculatePrice();
            double expectedprice = 4.0;

            //ASSERT

            Assert.AreEqual(priceofcart, priceoflist, expectedprice);
        }
    }
}