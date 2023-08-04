using ChallengeApp;
using System;
using System.Runtime.ExceptionServices;

Console.WriteLine(" Witamy w programie PeopleStat+ ");
Console.WriteLine(" ===============================");
Console.WriteLine();
Console.WriteLine(" Wprowadź ocenę z zakresu 0 - 100");
Console.WriteLine(" lub odpowiednią literę");
Console.WriteLine(" A = 100;  B = 80;  C = 60;   D = 40;  E = 20");
Console.WriteLine();
Console.WriteLine(" W celu podsumowania => Wciśnij Q");
Console.WriteLine("--------------------------------");

var employee = new Employee("Piotr", "Nowak");

while (true)
{
    Console.WriteLine(" Dodaj ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    {
        break;
    }

    try
    {
            if (input != null)
        {
            employee.AddScore(input);
        }
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }

}

var statistics = employee.GetStatistics();
Console.WriteLine("");
Console.WriteLine("----------------------------------");
Console.WriteLine($"Wynik: {statistics.AverageLetter}");
Console.WriteLine($"AVG: {statistics.Average:N1}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine("----------------------------------");