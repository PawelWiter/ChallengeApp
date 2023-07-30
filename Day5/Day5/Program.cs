//tablice
//int[] grades = new int[365];
//string[] dayOfWeeks = new string[7];
//dayOfWeeks[0] = "poniedziałek";
//dayOfWeeks[1] = "wtorek";
//dayOfWeeks[2] = "środa";
//dayOfWeeks[3] = "czwartek";
//dayOfWeeks[4] = "piątek";
//dayOfWeeks[5] = "sobota";
//dayOfWeeks[6] = "niedziela";
////Console.WriteLine(dayOfWeeks[2]);

////string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
////Console.WriteLine(dayOfWeeks2[0]);
//for (int i = 0; i < dayOfWeeks.Length; i=i+2)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

//listy
int[] grades = new int[365];
List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");
//Console.WriteLine(dayOfWeeks[2]);

//string[] dayOfWeeks2 = { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
//Console.WriteLine(dayOfWeeks2[0]);
//for (int i = 0; i < dayOfWeeks.Count; i++)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

foreach (var day in dayOfWeeks) 
{
    Console.WriteLine(day);
}

