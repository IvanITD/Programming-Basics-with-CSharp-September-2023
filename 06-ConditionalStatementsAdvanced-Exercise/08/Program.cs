int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int arivalHour = int.Parse(Console.ReadLine());
int arivalMinutes = int.Parse(Console.ReadLine());


int examToMinute = examHour * 60;
int arivalToMinutes = arivalHour * 60;

int totalExamMinuteTime = examToMinute + examMinutes;
int totalArivalMinuteTime = arivalToMinutes + arivalMinutes;

int totalTime = Math.Abs(totalExamMinuteTime - totalArivalMinuteTime);

int hour = totalTime / 60;
int minutes = totalTime % 60;

if (totalExamMinuteTime < totalArivalMinuteTime) // If the student is late
{
    Console.WriteLine("Late");
    if (hour == 0)
    {
        Console.WriteLine($"{minutes} minutes after the start");
    }
    else
    {
        Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
    }
}
else if (totalExamMinuteTime == totalArivalMinuteTime) // If the student is on time
{
    Console.WriteLine("On time");
    
}
else if (totalTime <= 30)
{
    Console.WriteLine("On time");
    Console.WriteLine($"{minutes} minutes before the start");
}
else if (totalExamMinuteTime > totalArivalMinuteTime || totalTime > 30) // If the student is early
{
    Console.WriteLine("Early");
    if (hour == 0)
    {
        Console.WriteLine($"{minutes} minutes before the start");
    }
    else
    {
        Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
    }
}



