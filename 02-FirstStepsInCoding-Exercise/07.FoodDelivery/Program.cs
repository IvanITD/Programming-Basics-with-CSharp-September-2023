int chickenMenuAmount = int.Parse(Console.ReadLine());
int fishMenuAmount = int.Parse(Console.ReadLine());
int vegeterianMenuAmount = int.Parse(Console.ReadLine());

double chickenMenuPrice = chickenMenuAmount * 10.35;
double fishMenuPrice = fishMenuAmount * 12.40;
double vegeterianMenuPrice = vegeterianMenuAmount * 8.15;

double totalPricing = chickenMenuPrice + fishMenuPrice + vegeterianMenuPrice;
double withDesert = totalPricing * 0.20;

double delivery = 2.50;

double finalPrice = totalPricing + withDesert + delivery;

Console.WriteLine(finalPrice);