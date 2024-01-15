string typeOfProjection = Console.ReadLine();
int lineAmmount = int.Parse(Console.ReadLine());
int columnsAmmount = int.Parse(Console.ReadLine());

double result = 0.00;

// Here we resolved the task with the if else statement
if (typeOfProjection == "Premiere")
{
    double premierePrice = 12.00;
    result = lineAmmount * columnsAmmount * premierePrice;
}
else if (typeOfProjection == "Normal")
{
    double normalPrice = 7.50;
    result = lineAmmount * columnsAmmount * normalPrice;
}
else if (typeOfProjection == "Discount")
{
    double discountPrice = 5.00;
    result = lineAmmount * columnsAmmount * discountPrice;
}
Console.WriteLine($"{result:F2} leva");

//Here we resolved the task with the switch case statement

switch (typeOfProjection)
{
    case "Premiere":
        double premierePrice = 12.00;
        result = lineAmmount * columnsAmmount * premierePrice;
        break;

    case "Normal":
        double normalPrice = 7.50;
        result = lineAmmount * columnsAmmount * normalPrice;
        break;

    case "Discount":
        double discountPrice = 5.00;
        result = lineAmmount * columnsAmmount * discountPrice;
        break;
}
Console.WriteLine($"{result:F2} leva");
