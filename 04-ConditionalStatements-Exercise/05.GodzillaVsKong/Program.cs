double movieBudget = double.Parse(Console.ReadLine());
int peopleAmount = int.Parse(Console.ReadLine());
double clothingPricePerOnePerson = double.Parse(Console.ReadLine());

double decorationPrice = movieBudget * 0.10;
double clothingPrice = peopleAmount * clothingPricePerOnePerson;

double discountforClothing = 0.0;

if (peopleAmount > 150)
{
    discountforClothing = clothingPrice * 0.10;
}

double totalClothing = clothingPrice - discountforClothing;

double totalPrice = decorationPrice + totalClothing;


double neededMoney = movieBudget - totalPrice;
double remainingMoney = totalPrice - movieBudget;


if (totalPrice > movieBudget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {Math.Abs(neededMoney):F2} leva more.");
}
else if (totalPrice <= movieBudget)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {Math.Abs(remainingMoney):F2} leva left.");
}
