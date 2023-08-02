using ChallengeApp;

Employee employee1 = new Employee("Piotr", "Kowalski");

employee1.AddScore(2.5);
employee1.AddScore("40");
employee1.AddScore(12.5445456);
employee1.AddScore(80);
employee1.AddScore(40);
employee1.AddScore('A');

var statistics = employee1.GetStatistics();
Console.WriteLine(statistics.AverageLetter);

Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.ReadLine();