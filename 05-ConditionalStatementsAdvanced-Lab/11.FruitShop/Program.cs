string fruit = Console.ReadLine();
string dayOfWeek = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

/* A small mistake to the name of the source code!
 * The name of this task is 11.FruitShop and NOT "12. Trade Commissions"*/

// Here we solve the task with the if else statement
if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thrusday" || dayOfWeek == "Friday")
{
    if (fruit == "banana")
    {
        double banana = 2.50;
        double price = quantity * banana;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "apple")
    {
        double apple = 1.20;
        double price = quantity * apple;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "orange")
    {
        double orange = 0.85;
        double price = quantity * orange;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "grapefruit")
    {
        double grapefruit = 1.45;
        double price = quantity * grapefruit;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "kiwi")
    {
        double kiwi = 2.70;
        double price = quantity * kiwi;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "pineapple")
    {
        double pineapple = 5.50;
        double price = quantity * pineapple;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "grapes")
    {
        double grapes = 3.85;
        double price = quantity * grapes;
        Console.WriteLine($"{price:F2}");
    }
    else
    {
        Console.WriteLine("error");
    }
}
else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
{
    if (fruit == "banana")
    {
        double banana = 2.70;
        double price = quantity * banana;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "apple")
    {
        double apple = 1.25;
        double price = quantity * apple;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "orange")
    {
        double orange = 0.90;
        double price = quantity * orange;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "grapefruit")
    {
        double grapefruit = 1.60;
        double price = quantity * grapefruit;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "kiwi")
    {
        double kiwi = 3.00;
        double price = quantity * kiwi;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "pineapple")
    {
        double pineapple = 5.60;
        double price = quantity * pineapple;
        Console.WriteLine($"{price:F2}");
    }
    else if (fruit == "grapes")
    {
        double grapes = 4.20;
        double price = quantity * grapes;
        Console.WriteLine($"{price:F2}");
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

// Here we solve the task with the switch case statement
switch (dayOfWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thrusday":
    case "Friday":
        switch (fruit)
        {
            case "banana":
                double banana = 2.50;
                double price = quantity * banana;
                Console.WriteLine($"{price:F2}");
            break;

            case "apple":
                double apple = 1.20;
                price = quantity * apple;
                Console.WriteLine($"{price:F2}");
            break;

            case "orange":
                double orange = 0.85;
                price = quantity * orange;
                Console.WriteLine($"{price:F2}");
            break;

            case "grapefruit":
                double grapefruit = 1.45;
                price = quantity * grapefruit;
                Console.WriteLine($"{price:F2}");
            break;

            case "kiwi":
                double kiwi = 2.70;
                price = quantity * kiwi;
                Console.WriteLine($"{price:F2}");
            break;

            case "pineapple":
                double pineapple = 5.50;
                price = quantity * pineapple;
                Console.WriteLine($"{price:F2}");
            break;

            case "grapes":
                double grapes = 3.85;
                price = quantity * grapes;
                Console.WriteLine($"{price:F2}");
            break;

            default:
                Console.WriteLine("error");
                break;
        }
    break;

    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana":
                double banana = 2.70;
                double price = quantity * banana;
                Console.WriteLine($"{price:F2}");
                break;

            case "apple":
                double apple = 1.25;
                price = quantity * apple;
                Console.WriteLine($"{price:F2}");
                break;

            case "orange":
                double orange = 0.90;
                price = quantity * orange;
                Console.WriteLine($"{price:F2}");
                break;

            case "grapefruit":
                double grapefruit = 1.60;
                price = quantity * grapefruit;
                Console.WriteLine($"{price:F2}");
                break;

            case "kiwi":
                double kiwi = 3.00;
                price = quantity * kiwi;
                Console.WriteLine($"{price:F2}");
                break;

            case "pineapple":
                double pineapple = 5.60;
                price = quantity * pineapple;
                Console.WriteLine($"{price:F2}");
                break;

            case "grapes":
                double grapes = 4.20;
                price = quantity * grapes;
                Console.WriteLine($"{price:F2}");
                break;

            default:
                Console.WriteLine("error");
                break;
        }
    break;

    default:
        Console.WriteLine("error");
        break;
}