using ChallengeApp;

Employee employee1 = new Employee("Piotr", "Kowalski", 33);

employee1.AddScore(2.5);
employee1.AddScore("40");
employee1.AddScore(12.5445456);
employee1.AddScore(30);
employee1.AddScore(40);

List<Employee> employees = new List<Employee>()
{
    employee1
};

foreach (var employee in employees)
{
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