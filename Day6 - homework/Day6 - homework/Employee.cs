namespace Day6___homework
{
    public class Employee //wszsytkie klasy powinniśmy przechowywać w oddzielnym pliku
    {

        private List<int> score = new List<int>();


        //// modyfikatory tu nie będą potrzebne, bo są obsłużone w polach (property)
        ////modyfikatory dostępu - to co jest stałe w trakcie programu powinno zostać private
        //private string name;
        //private string surname;
        //private int age;
        //private int scores;


        //konstruktory - mówią co, gdzie i kiedy wypełniać
        public Employee(string name, string surname, int age)
        {

            // TEN KOD co jest tutaj będzie wykonywane jak będziemy wywoływać new
            this.Name = name;
            this.Surname = surname;
            this.age = age;
            // this.score = 0; //tu już nie będzie potrzebne, bo stworzymy listę do tego
        }

        public string Name { get; private set; } // w ten sposób (polami/property) może być z zewnątrz ustawiany i pobierany
        public string Surname { get; private set; }
        public int age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        //metoda
        public void AddScore(int numberOfScore) // metoda, która ma dodać punkty naszemu użytkownikowi; w nawiasy wstawiamy zmianną, która będzie przechowywała punkty
        {
            //this.score = this.score + number; //poniżej alternatywny zapis
            this.score.Add(numberOfScore);  //dodajemy do tablicy score; 
        }

    }
}
