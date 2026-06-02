using Strategy.NaiveSolution;

var calculator = new OrderPriceCalculator();

var orderTotal = 100m;

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