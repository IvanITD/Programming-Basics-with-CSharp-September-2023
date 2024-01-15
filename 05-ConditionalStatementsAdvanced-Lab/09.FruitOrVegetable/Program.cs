string productName = Console.ReadLine();

//Here we solved the assignment with the if else statement
if (productName == "banana" || productName == "apple" || productName == "kiwi" || productName == "cherry" || productName == "lemon" || productName == "grapes")
{
    Console.WriteLine("fruit");
}
else if (productName == "tomato" || productName == "cucumber" || productName == "pepper" || productName == "carrot")
{
    Console.WriteLine("vegetable");
}
else
{
    Console.WriteLine("unknown");
}

//Here we solved the assignment with the switch case statement
switch (productName)
{
    case "banana":
    case "apple":
    case "kiwi":
    case "cherry":
    case "lemon":
    case "grapes":
        Console.WriteLine("fruit");
        break;

    case "tomato":
    case "cucumber":
    case "pepper":
    case "carrot":
        Console.WriteLine("vegetable");
        break;

    default:
        Console.WriteLine("unknown");
        break;
}