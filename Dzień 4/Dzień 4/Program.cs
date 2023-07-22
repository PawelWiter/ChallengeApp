Console.WriteLine("PRACA DOMOWA - DZIEŃ 4");
Console.WriteLine("------------------------");
Console.WriteLine("");

Console.WriteLine("Wpisz swoje imie i wciśnij ENTER");
string imie = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Teraz proszę podaj swoją płeć i wciśnij ENTER");
Console.WriteLine("1 = Kobieta");
Console.WriteLine("2 = Mężczyzna");
Console.WriteLine("-------------");
int plec = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Na koniec proszę wpisz swój wiek i wciśniej ENTER");
Console.WriteLine("");

int wiek = int.Parse(Console.ReadLine()); //Possible null reference argument

if (plec == 1)
{
    if (wiek < 33)
    {
        Console.WriteLine("Kobieta poniżej 30lat");
    }

    if (imie == "Ewa" && wiek == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
}

else if (plec == 2)
{
    if (wiek < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }

}
Console.WriteLine("");
Console.WriteLine("Gratuluję!. Przeszedłeś przez moją pierwszą pracę domową");
Console.WriteLine("");