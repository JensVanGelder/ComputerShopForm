using NUnit.Framework;

namespace ComputerShopForm.Test
{
    internal class ProductStockTest
    {
        public Product testproduct;
        public ShoppingCart testcart;

        [SetUp]
        public void Setup()
        {
            testcart = ShoppingCart.GetShoppingCart();
        }

        [TestCase(8, 1)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void AddProductToCart_WhenCalledWithGivenStock_ThenCheckIfProductWillIsAddedToCart(int stock, int expectedResult)
        {
            //ARRANGE
            testcart.ClearCart();
            testproduct = new GamingPc("TestComputer", 1, "https://placekitten.com/200/300", "Test description", 0, 1, "TestMOBO", "TestHDD", "TestCPU", "TestPSU", "TestGPU", Performance.Affordable, true);
            testproduct.Stock = stock;

            //ACT
            testcart.AddProductToCart(testproduct);

            //ASSERT

            Assert.AreEqual(expectedResult, testcart.Shoppinglist.Count);
        }
    }
}