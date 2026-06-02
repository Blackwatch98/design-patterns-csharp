namespace Strategy.PatternSolution.Discounts;

public class RegularDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal orderTotal)
    {
        return orderTotal;
    }
}
