double age = double.Parse(Console.ReadLine());
char sex = char.Parse(Console.ReadLine());

// Solved this task with the if else statement

if (sex == 'm')
{
	if (age >= 16)
	{
        Console.WriteLine("Mr.");
    }
	else if (age < 16)
	{
        Console.WriteLine("Master");
    }
}
else if (sex == 'f')
{
    if (age >= 16)
    {
        Console.WriteLine("Ms.");
    }
    else if (age < 16)
    {
        Console.WriteLine("Miss");
    }
}

// Solved this task with the switch case statement
switch (sex)
{
    case 'm':
        switch (age)
        {
            case >= 16:
                Console.WriteLine("Mr.");
                break;

            case < 16:
                Console.WriteLine("Master");
                break;
        }
        break;

    case 'f':
        switch (age)
        {
            case >= 16:
                Console.WriteLine("Ms.");
                break;

            case < 16:
                Console.WriteLine("Miss");
                break;
        }
        break;
}