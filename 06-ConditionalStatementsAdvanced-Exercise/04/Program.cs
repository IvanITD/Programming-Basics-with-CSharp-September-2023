int groupBudget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishersAmount = int.Parse(Console.ReadLine());

double rentPrice = 0.00;

if (season == "Spring")
{
    rentPrice = 3000;

    if (fishersAmount <= 6)
    {
        rentPrice -= (rentPrice * 0.10);
    }
    else if (fishersAmount >= 7 && fishersAmount <= 11)
    {
        rentPrice -= (rentPrice * 0.15);
    }
    else if (fishersAmount > 12)
    {
        rentPrice -= (rentPrice * 0.25);
    }

    if (fishersAmount % 2 == 0)
    {
        rentPrice -= (rentPrice * 0.05);
    }
}
else if (season == "Summer")
{
    rentPrice = 4200;

    if (fishersAmount <= 6)
    {
        rentPrice -= (rentPrice * 0.10);
    }
    else if (fishersAmount >= 7 && fishersAmount <= 11)
    {
        rentPrice -= (rentPrice * 0.15);
    }
    else if (fishersAmount > 12)
    {
        rentPrice -= (rentPrice * 0.25);
    }

    if (fishersAmount % 2 == 0)
    {
        rentPrice -= (rentPrice * 0.05);
    }
}
else if (season == "Autumn")
{
    rentPrice = 4200;

    if (fishersAmount <= 6)
    {
        rentPrice -= (rentPrice * 0.10);
    }
    else if (fishersAmount >= 7 && fishersAmount <= 11)
    {
        rentPrice -= (rentPrice * 0.15);
    }
    else if (fishersAmount > 12)
    {
        rentPrice -= (rentPrice * 0.25);
    }
}
else if (season == "Winter")
{
    rentPrice = 2600;

    if (fishersAmount <= 6)
    {
        rentPrice -= (rentPrice * 0.10);
    }
    else if (fishersAmount >= 7 && fishersAmount <= 11)
    {
        rentPrice -= (rentPrice * 0.15);
    }
    else if (fishersAmount > 12)
    {
        rentPrice -= (rentPrice * 0.25);
    }

    if (fishersAmount % 2 == 0)
    {
        rentPrice -= (rentPrice * 0.05);
    }
}

if (groupBudget >= rentPrice)
{
    Console.WriteLine($"Yes! You have {groupBudget - rentPrice:F2} leva left.");
}
else if (groupBudget < rentPrice)
{
    Console.WriteLine($"Not enough money! You need {rentPrice - groupBudget:F2} leva.");
}

