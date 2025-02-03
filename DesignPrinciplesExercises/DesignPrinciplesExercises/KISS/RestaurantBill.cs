using System;
using System.Linq;

namespace KISSPrinciple
{
    public class RestaurantBill
    {
        public decimal CalculateTotal(decimal[] prices, decimal tipPercentage = 10)
        {
            decimal total = prices.Sum();
            total += total * (tipPercentage / 100);
            return total;
        }
    }
}
