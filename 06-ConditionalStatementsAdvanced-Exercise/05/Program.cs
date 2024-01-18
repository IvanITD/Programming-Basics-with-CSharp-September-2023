double budget = double.Parse(Console.ReadLine());
string twoSeason = Console.ReadLine();

string destination = "";
string vacationType = "";
double percentFromBudget = 0.00;

if (twoSeason == "summer")
{
    if (budget <= 100)
    {
        destination = "Bulgaria";
        vacationType = "Camp";
        percentFromBudget = budget - (budget * 0.30);
    }
    else if (budget <= 1000)
    {
        destination = "Balkans";
        vacationType = "Camp";
        percentFromBudget = budget - (budget * 0.40);
    }
    else if (budget > 1000)
    {
        destination = "Europe";
        vacationType = "Hotel";
        percentFromBudget = budget - (budget * 0.90);
    }
}
else if (twoSeason == "winter")
{
    if (budget <= 100)
    {
        destination = "Bulgaria";
        vacationType = "Hotel";
        percentFromBudget = budget - (budget * 0.70);
    }
    else if (budget <= 1000)
    {
        destination = "Balkans";
        vacationType = "Hotel";
        percentFromBudget = budget - (budget * 0.80);
    }
    else if (budget > 1000)
    {
        destination = "Europe";
        vacationType = "Hotel";
        percentFromBudget = budget - (budget * 0.90);
    }
}

Console.WriteLine($"Somewhere in {destination} \n{vacationType} - {budget - percentFromBudget:F2}");