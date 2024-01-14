int number = int.Parse(Console.ReadLine());


//First way of solving this task is with the if else statement

if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5 || number == 6 || number == 7)
{
    if (number == 1)
    {
        Console.WriteLine("Monday");
    }
    else if (number == 2)
    {
        Console.WriteLine("Tuesday");
    }
    else if (number == 3)
    {
        Console.WriteLine("Wednesday");
    }
    else if (number == 4)
    {
        Console.WriteLine("Thursday");
    }
    else if (number == 5)
    {
        Console.WriteLine("Friday");
    }
    else if (number == 6)
    {
        Console.WriteLine("Saturday");
    }
    else if (number == 7)
    {
        Console.WriteLine("Sunday");
    }
    else
    {
        Console.WriteLine("Error");
    }
}
else
{
    Console.WriteLine("Error");
}


//The second way of solving this task is with the switch case

switch (number)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    case 4:
        Console.WriteLine("Thursday");
        break;

    case 5:
        Console.WriteLine("Friday");
        break;
    
    case 6:
        Console.WriteLine("Saturday");
        break;

    case 7:
        Console.WriteLine("Sunday");
        break;

    default:
        Console.WriteLine("Error");
        break;
}