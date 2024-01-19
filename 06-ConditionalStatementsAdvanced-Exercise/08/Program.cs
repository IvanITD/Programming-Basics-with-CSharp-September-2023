int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int arrivalHour = int.Parse(Console.ReadLine());
int arrivalMinutes = int.Parse(Console.ReadLine());

int examToMinute = examHour * 60 + examMinutes;
int arrivalToMinutes = arrivalHour * 60 + arrivalMinutes;

int totalTime = Math.Abs(examToMinute - arrivalToMinutes);
int hours = totalTime / 60;
int minutes = totalTime % 60;

if (examToMinute < arrivalToMinutes)
{
    Console.WriteLine("Late");
    Console.WriteLine(hours == 0 ? $"{minutes} minutes after the start" : $"{hours}:{minutes:D2} hours after the start");
}
else if (examToMinute == arrivalToMinutes)
{
    Console.WriteLine("On time");
}
else if (totalTime <= 30)
{
    Console.WriteLine("On time");
    Console.WriteLine($"{minutes} minutes before the start");
}
else
{
    Console.WriteLine("Early");
    Console.WriteLine(hours == 0 ? $"{minutes} minutes before the start" : $"{hours}:{minutes:D2} hours before the start");
}
