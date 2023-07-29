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



List<Employee> employees = new List<Employee>()
{
employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }

Console.WriteLine("Pracownik " + employeeWithMaxResult.Name + " " + "" + employeeWithMaxResult.Surname + " (lat: " + employeeWithMaxResult.age + ") uzyskał wynik " + employeeWithMaxResult.Result);



