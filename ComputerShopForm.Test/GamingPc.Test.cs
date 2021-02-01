using NUnit.Framework;

namespace ComputerShopForm.Test
{
    public class GamingPcTest
    {
        private GamingPc _testproduct;
        private ShoppingCart _testcart;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GamingPC_WhenStockIsZero_CanNotBeAddedToShoppingCart()
        {
            //ARRANGE
            //_testcart = ShoppingCart.GetShoppingCart();
            //_testproduct = new GamingPc("TestComputer", 1, "https://placekitten.com/200/300", "Test description", 1, 1, "TestMOBO",
            //    "TestHDD", "TestCPU", "TestPSU", "TestGPU", Performance.Affordable, true)
            //{
            //    Stock = 0
            //};

            //ACT
            //var output1 = testcart.ToString();
            int number1InCart = _testcart.ShoppingList.Count;

            _testcart.AddProductToCart(_testproduct);
            int number2InCart = _testcart.ShoppingList.Count;
            //var output2 = testcart.ToString();

            //ASSERT
            Assert.AreEqual(number1InCart, number2InCart);
        }
    }
}