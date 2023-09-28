double recordInSeconds = double.Parse(Console.ReadLine());
double distanceInMeters = double.Parse(Console.ReadLine());
double timeInSeconds = double.Parse(Console.ReadLine());

double swimmingTime = distanceInMeters * timeInSeconds;

double delay = Math.Floor(distanceInMeters / 15);

swimmingTime = swimmingTime + delay * 12.5;

if (swimmingTime < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {swimmingTime:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {Math.Abs(recordInSeconds - swimmingTime):F2} seconds slower.");
}
