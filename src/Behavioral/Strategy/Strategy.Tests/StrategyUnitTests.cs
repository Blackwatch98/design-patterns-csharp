using Shouldly;
using Strategy.NaiveSolution;

namespace Strategy.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateFinalPrice_ForRegularCustomer_ReturnsFullPrice()
        {
            var calculator = new OrderPriceCalculator();

            var result = calculator.CalculateFinalPrice(100m, CustomerType.Regular);

            result.ShouldBe(100m);
        }

        [Fact]
        public void CalculateFinalPrice_ForPremiumCustomer_ReturnsPriceWithTenPercentDiscount()
        {
            var calculator = new OrderPriceCalculator();

            var result = calculator.CalculateFinalPrice(100m, CustomerType.Premium);

            result.ShouldBe(90m);
        }

        [Fact]
        public void CalculateFinalPrice_ForVipCustomer_ReturnsPriceWithTwentyPercentDiscount()
        {
            var calculator = new OrderPriceCalculator();

            var result = calculator.CalculateFinalPrice(100m, CustomerType.Vip);

            result.ShouldBe(80m);
        }
    }
}
