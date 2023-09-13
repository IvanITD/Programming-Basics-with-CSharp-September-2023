int neededNaylonAmount = int.Parse(Console.ReadLine());
int neededPaintAmount = int.Parse(Console.ReadLine());
int thinnerAmount = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());


double naylonPrice = (neededNaylonAmount + 2) * 1.50;
double paintPrice = (neededPaintAmount + neededPaintAmount * 0.10) * 14.50;
double thinnerPrice = thinnerAmount * 5.00;


double bags = 0.40;

double totalExpence = naylonPrice + paintPrice + thinnerPrice + bags;

double workerPrice = hours * (totalExpence * 0.30);

double finalPrice = totalExpence + workerPrice;

Console.WriteLine(finalPrice);
