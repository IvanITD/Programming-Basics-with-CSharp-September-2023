string architectName = Console.ReadLine();
int projectAmmount = int.Parse(Console.ReadLine());

int timePerProject = 3;

int neededHours = projectAmmount * timePerProject;

Console.WriteLine($"The architect {architectName} will need {neededHours} " +
    $"hours to complete {projectAmmount} project/s.");
