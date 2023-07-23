Console.WriteLine("PRACA DOMOWA - DZIEŃ 4");
Console.WriteLine("------------------------");
Console.WriteLine("");

Console.WriteLine("Wpisz swoje name i wciśnij ENTER");
string name = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Teraz proszę podaj swoją płeć i wciśnij ENTER");
Console.WriteLine("1 = Kobieta");
Console.WriteLine("2 = Mężczyzna");
Console.WriteLine("-------------");
int gender = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Na koniec proszę wpisz swój age i wciśniej ENTER");
Console.WriteLine("");

int age = int.Parse(Console.ReadLine()); //Possible null reference argument

if (gender == 1)
{
    if (age < 33)
    {
        Console.WriteLine("Kobieta poniżej 30lat");
    }

    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
}

else if (gender == 2)
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }

}
Console.WriteLine("");
Console.WriteLine("Gratuluję!. Przeszedłeś przez moją pierwszą pracę domową");
Console.WriteLine("");