double deposit = double.Parse(Console.ReadLine());
int term = int.Parse(Console.ReadLine());
double AnualInterestRate = double.Parse(Console.ReadLine());

double sum = deposit + term * ((deposit * (AnualInterestRate / 100)) / 12);

Console.WriteLine(sum);