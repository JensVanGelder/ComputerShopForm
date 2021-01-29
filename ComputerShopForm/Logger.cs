namespace ComputerShopForm
{
    public abstract class Logger : ILogger
    {
        public abstract void LogPurchase(ShoppingCart cart);
    }
}