int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int  height = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double waterLiter = length * width * height;

double waterVolumeLiter = waterLiter * 0.001;

double usedSpace = percent / 100;

double neededLiters = waterVolumeLiter * (1 - usedSpace);

Console.WriteLine(neededLiters);