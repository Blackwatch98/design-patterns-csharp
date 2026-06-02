namespace Strategy.PatternSolution.Discounts;

public class PremiumDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal orderTotal)
    {
        return orderTotal * 0.90m;
    }
}
