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

var employee = new EmployeeInFile("Piotr", "Nowak");

while (true)
{
    Console.WriteLine(" Add grade for supervisor: ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
        if (input != null) { employee.AddScore(input); }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine("");
Console.WriteLine(" ----------------------------------");
Console.WriteLine($" Final Grade: {statistics.AverageLetter}");
Console.WriteLine($" AVG: {statistics.Average:N1}");
Console.WriteLine($" Min: {statistics.Min}");
Console.WriteLine($" Max: {statistics.Max}");
Console.WriteLine(" ----------------------------------");