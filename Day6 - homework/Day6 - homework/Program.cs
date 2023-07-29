using Day6___homework;

Employee employee1 = new Employee("Piotr", "Kowalski", 33);
Employee employee2 = new Employee("Anna", "Lewandowska", 22);
Employee employee3 = new Employee("Zenon", "Nowak", 55);

var name = employee1.Name;

employee1.AddScore(5);
employee1.AddScore(2);
var result = employee1.Result;
Console.WriteLine(result);