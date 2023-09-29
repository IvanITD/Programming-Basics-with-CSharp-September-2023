double petarBudget = double.Parse(Console.ReadLine());
int GPUAmount = int.Parse(Console.ReadLine());
int CPUAmount = int.Parse(Console.ReadLine());
int RAMAmount = int.Parse(Console.ReadLine());


double GPUPrice = GPUAmount * 250;
double CPUPrice = (GPUPrice * 0.35) * CPUAmount;
double RAMPrice = (GPUPrice * 0.10) * RAMAmount;

double totalPrice = GPUPrice + CPUPrice  + RAMPrice;

if (GPUAmount > CPUAmount)
{
    totalPrice -= totalPrice * 0.15;
}


if (totalPrice <= petarBudget)
{
    Console.WriteLine($"You have {petarBudget - totalPrice:F2} leva left!");
}
else if (totalPrice > petarBudget)
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(petarBudget - totalPrice):F2} leva more!");
}
