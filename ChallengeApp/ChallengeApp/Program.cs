using ChallengeApp;

Console.WriteLine(" Welcome in PeopleStat+ ");
Console.WriteLine(" ===============================");
Console.WriteLine();
Console.WriteLine(" You can choose your favorite range of grade");
Console.WriteLine(" Type grade from range 7 - 100");
Console.WriteLine(" or proper letter A = 100;B = 80;C = 60; D = 40;E = 20");
Console.WriteLine(" If you chooce and enter school grade,");
Console.WriteLine(" then 6 = 100, 5 = 80, ..., 1 = 0, '+' = +5, '-' = -5, ex. 5- = 85");
Console.WriteLine(" ");
Console.WriteLine(" For summary => press Q");
Console.WriteLine("--------------------------------");

var employee1 = new EmployeeInMemory("Piotr", "Nowak");
var employee2 = new EmployeeInFile("Jan", "Kowalski");
employee1.ScoreAdded += EmployeeScoreAdded;
employee2.ScoreAdded += EmployeeScoreAddedForSupervisor;

void EmployeeScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine($" Dodano nową ocenę dla {employee1.Name} {employee1.Surname}");
}
void EmployeeScoreAddedForSupervisor(object sender, EventArgs args)
{
    Console.WriteLine($" Dodano nową ocenę dla Kierownika {employee2.Name} {employee2.Surname}");
}

while (true)
{
    Console.WriteLine(" Add grade: ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        if (input != null) { employee2.AddScore(input); }
        if (input != null) { employee1.AddScore(input); }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}
var statistics = employee1.GetStatistics();

Console.WriteLine("");
Console.WriteLine(" ----------------------------------");
Console.WriteLine($" {employee1.Name} {employee1.Surname}");
Console.WriteLine($" Final Grade: {statistics.AverageLetter}");
Console.WriteLine($" AVG: {statistics.Average:N1}");
Console.WriteLine($" Min: {statistics.Min}");
Console.WriteLine($" Max: {statistics.Max}");
Console.WriteLine(" ----------------------------------");

var statisticsInFile = employee2.GetStatistics();

Console.WriteLine("");
Console.WriteLine(" ----------------------------------");
Console.WriteLine($" {employee2.Name} {employee2.Surname}");
Console.WriteLine($" Final Grade: {statisticsInFile.AverageLetter}");
Console.WriteLine($" AVG: {statisticsInFile.Average:N1}");
Console.WriteLine($" Min: {statisticsInFile.Min}");
Console.WriteLine($" Max: {statisticsInFile.Max}");
Console.WriteLine(" ----------------------------------");