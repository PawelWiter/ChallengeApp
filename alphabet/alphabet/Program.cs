//the easiest one
char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

foreach (char c in alphabet)
{
    Console.Write(c);
}
Console.WriteLine("");
Console.WriteLine("--------------------------");


//second solution
for (char c = 'a'; c <= 'z'; c++)
{
    Console.Write(c);
}
Console.WriteLine("");
Console.WriteLine("--------------------------");
