string cityName = Console.ReadLine(); 
double realSale = double.Parse(Console.ReadLine());

double commision;

// Here we solve the assignment with the if else statement

if (cityName == "Sofia")
{
    if (realSale >= 0 && realSale <= 500)
    {
        commision = realSale * 0.05;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 500 && realSale <= 1000)
    {
        commision = realSale * 0.07;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 1000 && realSale <= 10000)
    {
        commision = realSale * 0.08;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 10000)
    {
        commision = realSale * 0.12;
        Console.WriteLine($"{commision:F2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if (cityName == "Varna")
{
    if (realSale >= 0 && realSale <= 500)
    {
        commision = realSale * 0.045;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 500 && realSale <= 1000)
    {
        commision = realSale * 0.075;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 1000 && realSale <= 10000)
    {
        commision = realSale * 0.10;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 10000)
    {
        commision = realSale * 0.13;
        Console.WriteLine($"{commision:F2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if (cityName == "Plovdiv")
{
    if (realSale >= 0 && realSale <= 500)
    {
        commision = realSale * 0.055;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 500 && realSale <= 1000)
    {
        commision = realSale * 0.08;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 1000 && realSale <= 10000)
    {
        commision = realSale * 0.12;
        Console.WriteLine($"{commision:F2}");
    }
    else if (realSale > 10000)
    {
        commision = realSale * 0.145;
        Console.WriteLine($"{commision:F2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else
{
    Console.WriteLine("error");
}