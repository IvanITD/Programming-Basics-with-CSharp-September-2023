int firstTime = int.Parse(Console.ReadLine());
int secondTime = int.Parse(Console.ReadLine());
int thirdTime = int.Parse(Console.ReadLine());

int totalTime = firstTime + secondTime + thirdTime;

int timeInMinutes = totalTime / 60;
int timeInSeconds = totalTime % 60;

Console.WriteLine($"{timeInMinutes}:{timeInSeconds:D2}");