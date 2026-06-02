namespace Strategy.PatternSolution.Discounts;

public interface IDiscountStrategy
{
    public decimal ApplyDiscount(decimal orderTotal);
}
