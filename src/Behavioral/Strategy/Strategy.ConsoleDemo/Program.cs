using Strategy.NaiveSolution;
using Strategy.PatternSolution.Discounts;

using NaiveOrderPriceCalculator = Strategy.NaiveSolution.OrderPriceCalculator;
using PatternOrderPriceCalculator = Strategy.PatternSolution.OrderPriceCalculator;

var orderTotal = 100m;

RunNaiveSolutionDemo(orderTotal);
Console.WriteLine();
RunPatternSolutionDemo(orderTotal);

void RunNaiveSolutionDemo(decimal orderTotal)
{
    var calculator = new NaiveOrderPriceCalculator();

    Console.WriteLine("Strategy - Naive Solution");
    Console.WriteLine("-------------------------");

    PrintFinalPrice(CustomerType.Regular);
    PrintFinalPrice(CustomerType.Premium);
    PrintFinalPrice(CustomerType.Vip);

    void PrintFinalPrice(CustomerType customerType)
    {
        var finalPrice = calculator.CalculateFinalPrice(orderTotal, customerType);

        Console.WriteLine($"{customerType}: {orderTotal:C} -> {finalPrice:C}");
    }
}

void RunPatternSolutionDemo(decimal orderTotal)
{
    Console.WriteLine("Strategy - Pattern Solution");
    Console.WriteLine("---------------------------");

    PrintFinalPrice("Regular", new RegularDiscountStrategy());
    PrintFinalPrice("Premium", new PremiumDiscountStrategy());
    PrintFinalPrice("Vip", new VipDiscountStrategy());

    void PrintFinalPrice(string customerType, IDiscountStrategy discountStrategy)
    {
        var calculator = new PatternOrderPriceCalculator(discountStrategy);

        var finalPrice = calculator.CalculateFinalPrice(orderTotal);

        Console.WriteLine($"{customerType}: {orderTotal:C} -> {finalPrice:C}");
    }
}