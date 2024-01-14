using System.Runtime.CompilerServices;

string animalType = Console.ReadLine();

//This is the first way of solving the task with the if else statement

if (animalType == "dog")
{
    Console.WriteLine("mammal");
}
else if (animalType == "crocodile" || animalType == "tortoise" || animalType == "snake")
{
    Console.WriteLine("reptile");
}
else
{
    Console.WriteLine("unknown");
}

//This is the second way of solving the task with the switch case

switch (animalType)
{
    case "dog":
        Console.WriteLine("mammal");
        break;

    case "crocodile":
    case "tortoise":
    case "snake":
        Console.WriteLine("reptile");
        break;

    default:
        Console.WriteLine("unknown");
        break;
}