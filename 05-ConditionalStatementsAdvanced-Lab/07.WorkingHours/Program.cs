int hour = int.Parse(Console.ReadLine());
string dayFromWeek = Console.ReadLine();

if (dayFromWeek == "Monday" || dayFromWeek == "Tuesday" || dayFromWeek == "Wednesday" || dayFromWeek == "Thursday" || dayFromWeek == "Friday" || dayFromWeek == "Saturday")
{
   if (hour >= 10 && hour <= 18)
    {
        Console.WriteLine("open");
    }
   else
    {
        Console.WriteLine("closed");
    }
}
else if (dayFromWeek == "Sunday")
{
    Console.WriteLine("closed");
}
