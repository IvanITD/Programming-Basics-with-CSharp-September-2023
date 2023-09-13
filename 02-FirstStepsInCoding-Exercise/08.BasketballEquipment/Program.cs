int basketballYearSubscription = int.Parse(Console.ReadLine());

double shoes = basketballYearSubscription - (basketballYearSubscription * 0.40);
double outfit = shoes - (shoes * 0.20);
double basketball = outfit / 4;
double accessories = basketball / 5;

double taxPerYear = basketballYearSubscription + shoes + outfit + basketball + accessories;

Console.WriteLine(taxPerYear);