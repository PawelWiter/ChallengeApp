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
    employee1, //employee2, employee3
};


foreach (var employee in employees)
{
    var statistics = employee.GetStatistics();
    var statistics1 = employee.GetStatisticsWithForEach();
    var statistics2 = employee.GetStatisticsWithFor();
    var statistics3 = employee.GetStatisticsWithDoWhile();
    var statistics4 = employee.GetStatisticsWithWhile();

    Console.WriteLine($"GetStatisticsWithForEach");
    Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname} (Wiek: {employee.Age})");
    Console.WriteLine($"Average: {statistics1.Average:N2}");
    Console.WriteLine($"Min:{statistics1.Min}");
    Console.WriteLine($"Max:{statistics1.Max}");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();

    Console.WriteLine($"GetStatisticsWithForEach");
    Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname} (Wiek: {employee.Age})");
    Console.WriteLine($"Average: {statistics2.Average:N2}");
    Console.WriteLine($"Min:{statistics2.Min}");
    Console.WriteLine($"Max:{statistics2.Max}");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();

    Console.WriteLine($"GetStatisticsWithForEach");
    Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname} (Wiek: {employee.Age})");
    Console.WriteLine($"Average: {statistics3.Average:N2}");
    Console.WriteLine($"Min:{statistics3.Min}");
    Console.WriteLine($"Max:{statistics3.Max}");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();

    Console.WriteLine($"GetStatisticsWithForEach");
    Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname} (Wiek: {employee.Age})");
    Console.WriteLine($"Average: {statistics4.Average:N2}");
    Console.WriteLine($"Min:{statistics4.Min}");
    Console.WriteLine($"Max:{statistics4.Max}");
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
}