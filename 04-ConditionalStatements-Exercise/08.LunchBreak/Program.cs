string serialName = Console.ReadLine();
int episodeLength = int.Parse(Console.ReadLine());
int restLength = int.Parse(Console.ReadLine());

double timeForLunch = restLength * 0.125;
double timeForRest = restLength * 0.25;
double remainingTime = restLength - timeForLunch - timeForRest;


if (remainingTime >= episodeLength)
{
    Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(remainingTime - episodeLength)} minutes free time.");
}
else if (remainingTime < episodeLength)
{
    
    Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodeLength - remainingTime)} more minutes.");
}
