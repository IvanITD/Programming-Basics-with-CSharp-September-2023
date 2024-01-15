string dayOfWeek = Console.ReadLine();

// Here we use the if else statement in order to solve the assignment
if (dayOfWeek == "Monday")
{
    Console.WriteLine("12");
}
else if (dayOfWeek == "Tuesday")
{
    Console.WriteLine("12");
}
else if (dayOfWeek == "Wednesday")
{
    Console.WriteLine("14");
}
else if(dayOfWeek == "Thursday")
{
    Console.WriteLine("14");
}
else if (dayOfWeek == "Friday")
{
    Console.WriteLine("12");
}
else if (dayOfWeek == "Saturday")
{
    Console.WriteLine("16");
}
else if (dayOfWeek == "Sunday")
{
    Console.WriteLine("16");
}



// Here we use the switch case statement to solve the assignment
switch (dayOfWeek)
{
    case "Monday":
        Console.WriteLine("12");
        break;

    case "Tuesday":
        Console.WriteLine("12");
        break;

    case "Wednesday":
        Console.WriteLine("14");
        break;

    case "Thursday":
        Console.WriteLine("14");
        break;

    case "Friday":
        Console.WriteLine("12");
        break;

    case "Saturday":
        Console.WriteLine("16");
        break;
    
    case "Sunday":
        Console.WriteLine("16");
        break;
}