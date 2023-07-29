using Day6___homework;
//1. deklaracja klasy


///1. Stwórz klasę Employee, w której przechowasz imię, nazwisko, wiek 
///oraz punkty pracownika w postaci liczb całkowitych.
///
///2. Stwórz 3 pracowników i każdemu przydziel po 5 ocen z zakresu
///od 1 do 10.
///
///3. Napisz program, który wyszuka pracownika z najwyższą liczbą ocen
///a następnie wyświetli jego dane oraz wynik.
///
Employee employee1 = new Employee("Piotr", "Kowalski", 33);
Employee employee2 = new Employee("Anna", "Lewandowska", 22);
Employee employee3 = new Employee("Zenon", "Nowak", 55);

// employee1.name = "Piotr"; // możliwe jak zrobimy w modyfikatorze dostępu public

var name = employee1.Name;


employee1.AddScore(5); //w tej chwili tylko metoda AddScore pozwala na dodawanie punktów
employee1.AddScore(2);
var result = employee1.Result;
Console.WriteLine(  result);

// var nname = Employee.GameName; // zmienne statyczne związane są z typem, a nie z obiektem

