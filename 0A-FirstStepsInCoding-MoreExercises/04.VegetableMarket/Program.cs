double vegetablePricePerKg = double.Parse(Console.ReadLine());
double fruitPricePerKg = double.Parse(Console.ReadLine());
double totalVegetableKg = double.Parse(Console.ReadLine());
double totalFruitKg = double.Parse(Console.ReadLine());

double oneEuroInBgn = 1.94;

double totalVegetablePrice = vegetablePricePerKg * totalVegetableKg;
double totalFruitPrice = fruitPricePerKg * totalFruitKg;

double income = totalVegetablePrice + totalFruitPrice;

double incomeInEuro = income / oneEuroInBgn;

Console.WriteLine($"{incomeInEuro:F2}");