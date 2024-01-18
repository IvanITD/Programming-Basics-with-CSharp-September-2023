int N1 = int.Parse(Console.ReadLine());
int N2 = int.Parse(Console.ReadLine());
char symbol = char.Parse(Console.ReadLine());

double result = 0.00;

if (symbol == '+')
{
    result = N1 + N2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{N1} + {N2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{N1} + {N2} = {result} - odd");
    }
}
else if (symbol == '-')
{
    result = N1 - N2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{N1} - {N2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{N1} - {N2} = {result} - odd");
    }
}
else if (symbol == '*')
{
    result = N1 * N2;
    if (result % 2 == 0)
    {
        Console.WriteLine($"{N1} * {N2} = {result} - even");
    }
    else
    {
        Console.WriteLine($"{N1} * {N2} = {result} - odd");
    }
}
else if (symbol == '/')
{
    if (N1 == 0 || N2 == 0)
    {
        Console.WriteLine($"Cannot divide {N1} by zero");
    }
    else
    {
        result = (double)N1 / N2;
        Console.WriteLine($"{N1} / {N2} = {result:F2}");
    }
}
else if (symbol == '%')
{
    if (N1 == 0 || N2 == 0)
    {
        Console.WriteLine($"Cannot divide {N1} by zero");
    }
    else
    {
        result = N1 % N2;
        Console.WriteLine($"{N1} % {N2} = {result}");
    }
}
