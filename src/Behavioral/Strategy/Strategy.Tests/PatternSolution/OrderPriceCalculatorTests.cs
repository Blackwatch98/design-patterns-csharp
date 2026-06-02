using Shouldly;
using Strategy.PatternSolution.Discounts;

using OrderPriceCalculator = Strategy.PatternSolution.OrderPriceCalculator;

namespace Strategy.Tests.PatternSolution;

public class OrderPriceCalculatorTests
{
    [Fact]
    public void CalculateFinalPrice_WithRegularDiscountStrategy_ReturnsFullPrice()
    {
        var calculator = new OrderPriceCalculator(new RegularDiscountStrategy());

        var result = calculator.CalculateFinalPrice(100m);

        result.ShouldBe(100m);
    }

    [Fact]
    public void CalculateFinalPrice_WithPremiumDiscountStrategy_ReturnsPriceWithTenPercentDiscount()
    {
        var calculator = new OrderPriceCalculator(new PremiumDiscountStrategy());

        var result = calculator.CalculateFinalPrice(100m);

        result.ShouldBe(90m);
    }

    [Fact]
    public void CalculateFinalPrice_WithVipDiscountStrategy_ReturnsPriceWithTwentyPercentDiscount()
    {
        var calculator = new OrderPriceCalculator(new VipDiscountStrategy());

        var result = calculator.CalculateFinalPrice(100m);

        result.ShouldBe(80m);
    }
}
