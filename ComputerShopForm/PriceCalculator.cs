using System.Collections.Generic;

namespace ComputerShopForm
{
    internal class PriceCalculator : IPriceCalculator
    {
        public double CalculatePrice(List<IProduct> shoppinglist)
        {
            double price = new double();
            foreach (IProduct product in shoppinglist)
            {
                price += product.Price;
            }

            return price;
        }

        public double CalculateWithTax(List<IProduct> shoppinglist)
        {
            double tax = 0.21;
            return CalculatePrice(shoppinglist) * tax;
        }
    }
}