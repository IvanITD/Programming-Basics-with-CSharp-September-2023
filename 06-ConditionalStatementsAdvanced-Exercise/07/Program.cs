using System.Reflection;

string month = Console.ReadLine();
int overnightStayCount = int.Parse(Console.ReadLine());

double studio = 0.00;
double apartment = 0.00;

if (month == "May" || month == "October")
{
    studio = 50;
    studio *= overnightStayCount; // Price per night!
    apartment = 65;
    apartment *= overnightStayCount; // Price per night!


    if (overnightStayCount > 14)
    {
        studio -= (studio * 0.30); // За повече от 14 дни нощувки, намаление с 30%
        apartment -= (apartment * 0.10); // За повече от 14 дни нощувки, намаление с 10%, без значение от месеца!
    }
    else if(overnightStayCount > 7)
    {
        studio -= (studio * 0.05); // За повече от 7 дни нощувка, намаление с 5%
    }
     
}
else if (month == "June" || month == "September")
{
    studio = 75.20;
    studio *= overnightStayCount; // Price per night!
    apartment = 68.70;
    apartment *= overnightStayCount; // Price per night!

    if (overnightStayCount > 14)
    {
        studio -= (studio * 0.20); // За повече от 14 дни нощувки, намаление с 20%
        apartment -= (apartment * 0.10); // За повече от 14 дни нощувки, намаление с 10%, без значение от месеца!
    }
}
else if (month == "July" || month == "August")
{
    studio = 76;
    studio *= overnightStayCount; // Price per night!
    apartment = 77;
    apartment *= overnightStayCount; // Price per night!

    if (overnightStayCount > 14)
    {
        apartment -= (apartment * 0.10); // За повече от 14 дни нощувки, намаление с 10%, без значение от месеца!
    }
}

Console.WriteLine($"Apartment: {apartment:F2} lv.");
Console.WriteLine($"Studio: {studio:F2} lv.");