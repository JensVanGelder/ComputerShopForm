using System.IO;
using System.Text.Json;

namespace ComputerShopForm
{
    internal class JsonLogger : Logger
    {
        public override void LogPurchase(ShoppingCart cart)
        {
            using (StreamWriter file = new StreamWriter("log.json", true))
            {
                string serializer = JsonSerializer.Serialize(cart);
                file.WriteLine(serializer);
            }
        }
    }
}