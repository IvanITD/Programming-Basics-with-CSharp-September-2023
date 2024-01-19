int stayDays = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine(); // The option here are, "room for one person", "apartment" or "president apartment".
string grade = Console.ReadLine(); // The options here can be, "positive" or "negative".

// Here I wrote a code that diminishes the days count, in order to get the right day sum!
// In order to get the days right, we need to count them example: 11 day, but we count 10 nights, because of the stay!
stayDays--; // Minus one day because of the stay!

// Here I create a separate double variable named result, in order late, to be able to print the answer outside the if -else statement!
double result = 0.00;

if (roomType == "room for one person")
{
    if (stayDays > 15)
    {
        double roomForOnePerson = 18.00;

        if (grade == "positive")
        {
            roomForOnePerson += (roomForOnePerson * 0.25);
            result = roomForOnePerson * stayDays;
        }
        else if (grade == "negative")
        {
            roomForOnePerson -= (roomForOnePerson * 0.10);
            result = roomForOnePerson * stayDays;
        }
    }
    else if(stayDays >= 10 && stayDays <= 15)
    {
        double roomForOnePerson = 18.00;
        result = roomForOnePerson * stayDays;

        if (grade == "positive")
        {
            roomForOnePerson += (roomForOnePerson * 0.25);
            result = roomForOnePerson * stayDays;
        }
        else if (grade == "negative")
        {
            roomForOnePerson -= (roomForOnePerson * 0.10);
            result = roomForOnePerson * stayDays;
        }
    }
    else if (stayDays < 10)
    {
        double roomForOnePerson = 18.00;
        result = roomForOnePerson * stayDays;

        if (grade == "positive")
        {
            roomForOnePerson += (roomForOnePerson * 0.25);
            result = roomForOnePerson * stayDays;
        }
        else if (grade == "negative")
        {
            roomForOnePerson -= (roomForOnePerson * 0.10);
            result = roomForOnePerson * stayDays;
        }
    }
}
else if (roomType == "apartment")
{
    if (stayDays > 15)
    {
        double apartment = 25.00;
        apartment -= (apartment * 0.50);

        if (grade == "positive")
        {
            apartment += (apartment * 0.25);
            result = apartment * stayDays;
        }
        else if (grade == "negative")
        {
            apartment -= (apartment * 0.10);
            result = apartment * stayDays;
        }
    }
    else if(stayDays >= 10 && stayDays <= 15)
    {
        double apartment = 25.00;
        apartment -= (apartment * 0.35);

        if (grade == "positive")
        {
            apartment += (apartment * 0.25);
            result = apartment * stayDays;
        }
        else if (grade == "negative")
        {
            apartment -= (apartment * 0.10);
            result = apartment * stayDays;
        }
    }
    else if (stayDays < 10)
    {
        double apartment = 25.00;
        apartment -= (apartment * 0.30);

        if (grade == "positive")
        {
            apartment += (apartment * 0.25);
            result = apartment * stayDays;
        }
        else if (grade == "negative")
        {
            apartment -= (apartment * 0.10);
            result = apartment * stayDays;
        }
    }
}
else if (roomType == "president apartment")
{
    if (stayDays > 15)
    {
        double presidentApartment = 35.00;
        presidentApartment -= (presidentApartment * 0.20);

        if (grade == "positive")
        {
            presidentApartment += (presidentApartment * 0.25);
            result = presidentApartment * stayDays;
        }
        else if (grade == "negative")
        {
            presidentApartment -= (presidentApartment * 0.10);
            result = presidentApartment * stayDays;
        }
    }
    else if(stayDays >= 10 && stayDays <= 15)
    {
        double presidentApartment = 35.00;
        presidentApartment -= (presidentApartment * 0.15);

        if (grade == "positive")
        {
            presidentApartment += (presidentApartment * 0.25);
            result = presidentApartment * stayDays;
        }
        else if (grade == "negative")
        {
            presidentApartment -= (presidentApartment * 0.10);
            result = presidentApartment * stayDays;
        }
    }
    else if (stayDays < 10)
    {
        double presidentApartment = 35.00;
        presidentApartment -= (presidentApartment * 0.10);

        if (grade == "positive")
        {
            presidentApartment += (presidentApartment * 0.25);
            result = presidentApartment * stayDays;
        }
        else if (grade == "negative")
        {
            presidentApartment -= (presidentApartment * 0.10);
            result = presidentApartment * stayDays;
        }
    }    
}

Console.WriteLine($"{result:F2}");