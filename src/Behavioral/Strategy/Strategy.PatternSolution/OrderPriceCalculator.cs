using Strategy.PatternSolution.Discounts;

namespace Strategy.PatternSolution;

public class OrderPriceCalculator
{
    private readonly IDiscountStrategy _discountStrategy;
    
    public OrderPriceCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public decimal CalculateFinalPrice(decimal orderTotal)
    {
        return _discountStrategy.ApplyDiscount(orderTotal);
    }
}
