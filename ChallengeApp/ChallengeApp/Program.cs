using ChallengeApp;

Console.WriteLine(" Witamy w programie PeopleStat+ ");
Console.WriteLine(" ===============================");
Console.WriteLine();
Console.WriteLine(" Wprowadź ocenę z zakresu 0 - 100");
Console.WriteLine(" lub ");
Console.WriteLine(" A = 100;  B = 80;  C = 60;   D = 40;  E = 20");
Console.WriteLine();
Console.WriteLine(" W celu podsumowania => Wciśnij Q");
Console.WriteLine();

var employee = new Employee("Piotr", "Nowak");

while (true)
{
    Console.WriteLine(" Dodaj ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }
    else if (input != null)
    {
        employee.AddScore(input);
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Wynik: {statistics.AverageLetter}" );
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");