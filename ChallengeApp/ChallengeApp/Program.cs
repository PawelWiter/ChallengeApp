using ChallengeApp;

Employee employee1 = new Employee("Piotr", "Kowalski", 33);
Employee employee2 = new Employee("Anna", "Lewandowska", 22);
Employee employee3 = new Employee("Zenon", "Nowak", 55);


employee1.AddScore(2.5);
employee1.AddScore("40");
employee1.AddScore(12.5445456);
employee1.AddScore(30);
employee1.AddScore(40);

employee2.AddScore(1);
employee2.AddScore(3.55);
employee2.AddScore(4);
employee2.AddScore(5D);
employee2.AddScore(6);

employee3.AddScore(5);
employee3.AddScore("66");
employee3.AddScore(33.33333);
employee3.AddScore(0.23333333333333);
employee3.AddScore(1);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

foreach (var employee in employees)
{
    var statistics = employee.GetStatistics();

    Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname} (Wiek: {employee.Age})");
    Console.WriteLine($"Average: {statistics.Average:N2}");
    Console.WriteLine($"Min:{statistics.Min}");
    Console.WriteLine($"Max:{statistics.Max}");
    Console.WriteLine();
}