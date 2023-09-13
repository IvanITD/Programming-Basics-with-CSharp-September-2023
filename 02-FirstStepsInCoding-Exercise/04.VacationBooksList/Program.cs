int pageAmmount = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysAmmount = int.Parse(Console.ReadLine());

int neededHoursToRead = pageAmmount / pagesPerHour;
int neededHoursPerDay = neededHoursToRead / daysAmmount;

Console.WriteLine(neededHoursPerDay);