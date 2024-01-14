string dayOfWeek = Console.ReadLine();

// Firstly we will write the solution of this task with the if else statement

if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
{
    Console.WriteLine("Working day");
}
else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
{
    Console.WriteLine("Weekend");
}
else
{
    Console.WriteLine("Error");
}


// The second solution is with the switch case

switch (dayOfWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        Console.WriteLine("Working day");
        break;

    case "Saturday":
    case "Sunday":
        Console.WriteLine("Weekend");
        break;
        default:
        Console.WriteLine("Error");
            break;


        //For this task we resolved the problem with two different solutions
}