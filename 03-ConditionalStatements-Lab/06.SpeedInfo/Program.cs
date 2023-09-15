double pace = double.Parse(Console.ReadLine());

if (pace <= 10)
{
    Console.WriteLine("slow");
}
else if (pace > 10 && pace <= 50)
{
    Console.WriteLine("average");
}
else if (pace > 50 && pace <= 150)
{
    Console.WriteLine("fast");
}
else if (pace > 150 && pace <= 1000)
{
    Console.WriteLine("ultra fast");
}
else
{
    Console.WriteLine("extremely fast");
}
