int startingPoints = int.Parse(Console.ReadLine());

double bonusPoints = 0.0;

if (startingPoints <= 100)
{
    bonusPoints += 5;

    if (startingPoints % 2 == 0)
    {
        bonusPoints++;

    }
    
    if (startingPoints % 10 == 5)
    {
        bonusPoints += 2;
    }

    double totalPoints = startingPoints + bonusPoints;

    Console.WriteLine(bonusPoints);
    Console.WriteLine(totalPoints);
}
else if (startingPoints > 100 && startingPoints <= 1000)
{
    bonusPoints = startingPoints * 0.20;

    if (startingPoints % 2 == 0)
    {
        bonusPoints++;

    }
    
    if (startingPoints % 10 == 5)
    {
        bonusPoints += 2;
    }

    double totalPoints = startingPoints + bonusPoints;

    Console.WriteLine(bonusPoints);
    Console.WriteLine(totalPoints);
}
else if (startingPoints > 1000)
{
    bonusPoints = startingPoints * 0.10;

    if (startingPoints % 2 == 0)
    {
        bonusPoints++;

    }
    
    if (startingPoints % 10 == 5)
    {
        bonusPoints += 2;
    }

    double totalPoints = startingPoints + bonusPoints;

    Console.WriteLine(bonusPoints);
    Console.WriteLine(totalPoints);
}
