using System.ComponentModel.Design;

string flowersType = Console.ReadLine();
int flowersAmmount = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double roses = 5.00;
double dahlias = 3.80;
double tulips = 2.80;
double narcissus = 3.00;
double gladiolus = 2.50;

double price = 0.00;

// Here we solved the task with the if-else statement
if (flowersType == "Roses")
{
	if (flowersAmmount > 80)
	{
		price = flowersAmmount * roses;
		 price -= (price * 0.10);
	}
	else
	{
        price = flowersAmmount * roses;
    }
}
else if (flowersType == "Dahlias")
{
	if (flowersAmmount > 90)
	{
		price = flowersAmmount * dahlias;
		 price -= (price * 0.15);
	}
	else
	{
        price = flowersAmmount * dahlias;
    }
}
else if (flowersType == "Tulips")
{
	if (flowersAmmount > 80)
	{
		price = flowersAmmount * tulips;
		 price -= (price * 0.15);
	}
	else
	{
        price = flowersAmmount * tulips;
    }
}
else if (flowersType == "Narcissus")
{
	if (flowersAmmount < 120)
	{
		price = flowersAmmount * narcissus;
		 price += (price * 0.15);
	}
	else
	{
        price = flowersAmmount * narcissus;
    }
}
else if (flowersType == "Gladiolus")
{
	if (flowersAmmount < 80)
	{
		 price = flowersAmmount * gladiolus;
		 price += (price * 0.20);
	}
	else
	{
         price = flowersAmmount * gladiolus;
    }
}

if (budget >= price)
{
    Console.WriteLine($"Hey, you have a great garden with {flowersAmmount} {flowersType} and {budget - price:F2} leva left.");
}
else if (budget < price)
{
    Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
}
