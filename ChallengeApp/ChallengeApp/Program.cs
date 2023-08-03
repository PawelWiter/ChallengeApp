using ChallengeApp;

Console.WriteLine("Witamy w programie PeopleStat+ ");
Console.WriteLine("===============================");
Console.WriteLine();
Console.WriteLine("Q - wyjście");
Console.WriteLine();

var employee = new Employee("Piotr", "Nowak");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q" || input == "Q")
    {
        break;
    }
    if(input != null)
    {
        employee.AddScore(input);
    }  
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


//działając aplikacja do oceny pracownika (jednego)
//działające testy jednostkowe wraz ze sprawdzeniem liter A/B/C...
//na git