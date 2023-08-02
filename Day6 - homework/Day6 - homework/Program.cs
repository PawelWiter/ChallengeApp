using ChallengeApp;
using Day6___homework;

Employee employee1 = new Employee("Piotr", "Kowalski", 33);
Employee employee2 = new Employee("Anna", "Lewandowska", 22);
Employee employee3 = new Employee("Zenon", "Nowak", 55);

employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(8);
employee1.AddScore(9);

employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(6);

employee3.AddScore(5);
employee3.AddScore(4);
employee3.AddScore(3);
employee3.AddScore(2);
employee3.AddScore(1);

var statistics = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");


