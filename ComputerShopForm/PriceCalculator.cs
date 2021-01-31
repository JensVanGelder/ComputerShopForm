using System.Collections.Generic;
using System.Linq;

namespace ComputerShopForm
{
    public class PriceCalculator : IPriceCalculator
    {
        private const double Tax = 0.21;

        public double CalculatePrice(List<IProduct> shoppinglist)
        {
            return shoppinglist.Sum(product => product.Price);
        }

        public double CalculateTax(List<IProduct> shoppinglist)
        {
            return CalculatePrice(shoppinglist) * Tax;
        }
    }
}