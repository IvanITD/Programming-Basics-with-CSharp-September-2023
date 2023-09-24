
double priceForExcursion = double.Parse(Console.ReadLine());
int puzzleAmount = int.Parse(Console.ReadLine());
int talkingDollsAmount = int.Parse(Console.ReadLine());
int tedyBearAmount = int.Parse(Console.ReadLine());
int minionsAmount = int.Parse(Console.ReadLine());
int trucksAmount = int.Parse(Console.ReadLine());

int totalToys = puzzleAmount + talkingDollsAmount + tedyBearAmount + minionsAmount + trucksAmount;

double puzzlePrice = puzzleAmount * 2.60;
double talkingDollPrice = talkingDollsAmount * 3;
double tedyBearPrice = tedyBearAmount * 4.10;
double minionsPrice = minionsAmount * 8.20;
double truckPrice = trucksAmount * 2;

double totalPrice = puzzlePrice + talkingDollPrice + tedyBearPrice + minionsPrice + truckPrice;

if (totalToys >= 50)
{
    double discount = totalPrice * 0.25;
    double discountFromTotalPrice = totalPrice - discount;

    double rentPrice = discountFromTotalPrice * 0.10;
    double profit = discountFromTotalPrice - rentPrice;

    if (profit > priceForExcursion)
    {
        Console.WriteLine($"Yes! {profit - priceForExcursion:F2} lv left.");
    }
    else
    {
        Console.WriteLine($"Not enough money! {priceForExcursion - profit:F2} lv needed.");
    }
}
else
{
    double rentPrice = totalPrice * 0.10;
    double profit = totalPrice - rentPrice;

    if (profit > priceForExcursion)
    {
        Console.WriteLine($"Yes! {profit - priceForExcursion:F2} lv left.");
    }
    else
    {
        Console.WriteLine($"Not enough money! {priceForExcursion - profit:F2} lv needed.");
    }
}
