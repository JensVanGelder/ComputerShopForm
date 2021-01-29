using System.Collections.Generic;

namespace ComputerShopForm
{
    public interface IPriceCalculator
    {
        double CalculatePrice(List<IProduct> shoppinglist);

        double CalculateWithTax(List<IProduct> shoppinglist);
    }
}