namespace Strategy.PatternSolution.Discounts;

public class VipDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal orderTotal)
    {
        return orderTotal * 0.80m;
    }
}
