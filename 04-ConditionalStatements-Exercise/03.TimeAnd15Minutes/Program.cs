int inputHours = int.Parse(Console.ReadLine());
int inputMinutes = int.Parse(Console.ReadLine());

int hoursToMinuts = inputHours * 60;

int totalMinuteTime = hoursToMinuts + inputMinutes;

totalMinuteTime += 15; // The 15 minutes from the assigment

int hours = 0;

int minutes = totalMinuteTime % 60;
hours = totalMinuteTime / 60;

if (hours == 24)
{
    hours = 0;
   
    if (minutes == 60)
    {
        hours++;
        minutes = 0;
    }
}

Console.WriteLine($"{hours}:{minutes:D2}");