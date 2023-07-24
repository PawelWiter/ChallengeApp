///Przygotuj program, który policzy ile jakich cyfr
////występuje w podanej liczbie

using System;
using System.Runtime.CompilerServices;
///Przygotuj program, który policzy ile jakich cyfr
///
///Przykład:
///Wyniki dla liczby: 4566
///0=>0
///1=>0
///2=>0
///3=>0
///4=>1
///5=>1
///6=>2
///7=>0
///8=>0
///9=>0
///

//int number = 4566;
//string numberInString = number.ToString(); 
//char[] letters = numberInString.ToArray();


Console.WriteLine("Podaj dowolną liczbę całkowitą i wciśnij ENTER");
Console.WriteLine("----------------------------------------------");
var number = Console.ReadLine();

char[] letters = number.ToArray(); //dostaniemy tablicę pojedynczych znaków 

Console.WriteLine("");
Console.WriteLine("Liczba powtórzeń danej cyfry w podanej liczbie: " + number);
Console.WriteLine("-----------------------------------------------");

//tworzę listę cyfr
List<int> digits = new List<int>();
for (int i = 0; i < 10; i++)
    digits.Add(i);
//-----------------

//każdy indeks będzie przechowywał sumę
List<int> sumOfNumbers = new List<int>();
foreach (int i in digits)
    sumOfNumbers.Add(0);
//-----------------

//sprawdzamy każdą cyfrę ze wskazanej liczby i updatujemy odpowiedni indeks w sumOfNumbers
foreach (char c in letters)
{
    foreach (int i2 in digits)
        if ((c - '0') == i2)
        {
            sumOfNumbers[i2]++;
        }
}

//wypisujemy wyniki na końcu programu
int index = 0;
foreach (int n in sumOfNumbers)
{
    Console.WriteLine($"{index}=> {n}");
    index++;
}



