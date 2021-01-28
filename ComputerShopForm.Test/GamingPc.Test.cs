using NUnit.Framework;
using ComputerShopForm;
using System.Collections.Generic;
using System.IO;
using System;

namespace ComputerShopForm.Test
{
    public class Tests
    {
        public GamingPc testproduct;
        public ShoppingCart testcart;
        public List<IProduct> testcart2;

        [SetUp]
        public void Setup()
        {
            testproduct = new GamingPc("TestComputer", 1, "https://placekitten.com/200/300", "Test description", 1, 1, "TestMOBO", "TestHDD", "TestCPU", "TestPSU", "TestGPU", Performance.Affordable, true);
            testcart = ShoppingCart.GetShoppingCart();
        }

        [Test]
        public void GamingPC_WhenStockIsZero_CanNotBeAddedToShoppingCart()
        {
            //ARRANGE

            testproduct.Stock = 0;
            //ACT
            //var output1 = testcart.ToString();
            int number1incart = testcart.Shoppinglist.Count;

            testcart.AddProductToCart(testproduct);
            int number2incart = testcart.Shoppinglist.Count;
            //var output2 = testcart.ToString();

            //ASSERT
            Assert.AreNotEqual(number1incart, number2incart);
        }
    }
}