using System.Collections.Generic;
using System.Linq;

namespace ComputerShopForm
{
    internal class PriceCalculator : IPriceCalculator
    {
        private const double TAX = 0.21;

        public double CalculatePrice(List<IProduct> shoppinglist)
        {
            return shoppinglist.Sum(product => product.Price);
        }

        public double CalculateWithTax(List<IProduct> shoppinglist)
        {
            return CalculatePrice(shoppinglist) * TAX;
        }
    }
}