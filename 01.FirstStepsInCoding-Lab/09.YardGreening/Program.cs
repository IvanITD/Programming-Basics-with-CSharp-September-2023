double squareMeters = double.Parse(Console.ReadLine());

double perOneSquareMeter = 7.61;
double discount = 0.18;

double totalGreeningPrice = squareMeters * perOneSquareMeter;
double discountedPrice = discount * totalGreeningPrice;
double finalPrice = totalGreeningPrice - discountedPrice;

Console.WriteLine($"The final price is: {finalPrice} lv.");
Console.WriteLine($"The discount is: {discountedPrice} lv.");