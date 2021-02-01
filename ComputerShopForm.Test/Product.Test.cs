using NUnit.Framework;

namespace ComputerShopForm.Test
{
    internal class ProductTest
    {
        private Product _testproduct;
        private ShoppingCart _testcart;

        [SetUp]
        public void Setup()
        {
            _testcart = ShoppingCart.GetShoppingCart();
        }

        [TestCase(8, 1)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void AddProductToCart_WhenCalledWithGivenStock_ThenCheckIfProductWillBeAddedToCart(int stock, int expectedResult)
        {
            //ARRANGE
            _testcart.ClearCart();
            _testproduct = new GamingPc(1, "TestComputer", 1, "https://placekitten.com/200/300", "Test description", 0, 1,
                "TestMOBO", "TestHDD", "TestCPU", "TestPSU", "TestGPU", Performance.Affordable, true)
            {
                Stock = stock
            };

            //ACT
            _testcart.AddProductToCart(_testproduct);

            //ASSERT

            Assert.AreEqual(expectedResult, _testcart.ShoppingList.Count);
        }
    }
}