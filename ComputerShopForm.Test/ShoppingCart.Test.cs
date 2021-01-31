using NUnit.Framework;

namespace ComputerShopForm.Test
{
    internal class ShoppingCartTest
    {
        private IProduct _testproduct;
        private ShoppingCart _testcart;

        [SetUp]
        public void Setup()
        {
            _testcart = ShoppingCart.GetShoppingCart();

            _testproduct = new GamingPc("TestComputer", 1, "https://placekitten.com/200/300", "Test description", 1, 0, "TestMOBO", "TestHDD", "TestCPU", "TestPSU", "TestGPU", Performance.Affordable, true);
        }

        [Test]
        public void AddProductToCart_WhenPriceIsCalculated_PriceIsCorrect()
        {
            //ARRANGE
            _testcart.AddProductToCart(_testproduct);
            _testcart.AddProductToCart(_testproduct);
            _testcart.AddProductToCart(_testproduct);
            _testcart.AddProductToCart(_testproduct);

            //ACT
            double priceofcart = _testcart.CalculatePrice();

            //ASSERT
            Assert.AreEqual(4.0*1.21, priceofcart);
        }

        [Test]
        public void RemoveProductFromCart_WhenCalled_IsRemovedFormCart()
        {
            //ARRANGE
            _testcart.AddProductToCart(_testproduct);
            _testcart.AddProductToCart(_testproduct);
            _testcart.AddProductToCart(_testproduct);
            _testcart.AddProductToCart(_testproduct);

            //ACT
            _testcart.RemoveProductFromCart(_testproduct.Name);

            //ASSERT
            Assert.AreEqual(_testcart.ShoppingList.Count, 3);
        }

        [Test]
        public void ClearCart_WhenCalled_ShoppinglistIsEmpty()
        {
            _testcart.AddProductToCart(_testproduct);
            _testcart.AddProductToCart(_testproduct);

            _testcart.ClearCart();

            Assert.AreEqual(0, _testcart.ShoppingList.Count);
        }
        [Test]
        public void GetShoppingCart_WhenCalledIfCartIsNull_MakesNewCart()
        {
            _testcart = ShoppingCart.GetShoppingCart();
            Assert.IsNotNull(_testcart);
        }
    }
}