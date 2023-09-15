string figureType = Console.ReadLine();

if (figureType == "square")
{
    double length = double.Parse(Console.ReadLine());
    double area = length * length;

    Console.WriteLine($"{area:F3}");
}
else if (figureType == "rectangle")
{
    double lengthA = double.Parse(Console.ReadLine());
    double lengthB = double.Parse(Console.ReadLine());
    double area = lengthA * lengthB;

    Console.WriteLine($"{area:F3}");
}
else if (figureType == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    double area = Math.PI * radius * radius;

    Console.WriteLine($"{area:F3}");
}
else if (figureType == "triangle")
{
    double lengthA = double.Parse(Console.ReadLine());
    double lengthB = double.Parse(Console.ReadLine());
    double area = lengthA * lengthB / 2;

    Console.WriteLine($"{area:F3}");
}
