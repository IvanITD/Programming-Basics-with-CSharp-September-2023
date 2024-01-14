string product = Console.ReadLine();
string city = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

double coffee;
double water;
double beer;
double sweets;
double peanuts;

// Here we solved the task using the if else statement

if (city == "Sofia")
{
    if (product == "coffee")
    {
        coffee = 0.50;
        quantity *= coffee;
    }
    else if (product == "water")
    {
        water = 0.80;
        quantity *= water;
    }
    else if (product == "beer")
    {
        beer = 1.20;
        quantity *= beer;
    }
    else if (product == "sweets")
    {
        sweets = 1.45;
        quantity *= sweets;
    }
    else if (product == "peanuts")
    {
        peanuts = 1.60;
        quantity *= peanuts;
    }
}
else if (city == "Plovdiv")
{
    if (product == "coffee")
    {
        coffee = 0.40;
        quantity *= coffee;
    }
    else if (product == "water")
    {
        water = 0.70;
        quantity *= water;
    }
    else if (product == "beer")
    {
        beer = 1.15;
        quantity *= beer;
    }
    else if (product == "sweets")
    {
        sweets = 1.30;
        quantity *= sweets;
    }
    else if (product == "peanuts")
    {
        peanuts = 1.50;
        quantity *= peanuts;
    }
}
else if (city == "Varna")
{
    if (product == "coffee")
    {
        coffee = 0.45;
        quantity *= coffee;
    }
    else if (product == "water")
    {
        water = 0.70;
        quantity *= water;
    }
    else if (product == "beer")
    {
        beer = 1.10;
        quantity *= beer;
    }
    else if (product == "sweets")
    {
        sweets = 1.35;
        quantity *= sweets;
    }
    else if (product == "peanuts")
    {
        peanuts = 1.55;
        quantity *= peanuts;
    }
}
Console.WriteLine(quantity);
