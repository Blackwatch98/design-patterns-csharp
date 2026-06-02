namespace Strategy.NaiveSolution;

public enum CustomerType
{
    Regular,
    Premium,
    Vip
}

public class OrderPriceCalculator
{
    public decimal CalculateFinalPrice(decimal orderTotal, CustomerType customerType)
    {
        if (customerType == CustomerType.Regular)
        {
            return orderTotal;
        }

        if (customerType == CustomerType.Premium)
        {
            return orderTotal * 0.90m;
        }

        if (customerType == CustomerType.Vip)
        {
            return orderTotal * 0.80m;
        }

        throw new ArgumentOutOfRangeException(nameof(customerType));
    }
}