int dogFood = int.Parse(Console.ReadLine());
int catFood = int.Parse(Console.ReadLine());

double oneDogPack = 2.50;
double oneCatPack = 4.0;

double totalDogFoodPrice = dogFood * oneDogPack;
double totalCatFoodPrice = catFood * oneCatPack;

double totalExpence = totalDogFoodPrice + totalCatFoodPrice;

Console.WriteLine($"{totalExpence} lv.");