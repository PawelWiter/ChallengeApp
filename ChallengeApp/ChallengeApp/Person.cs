namespace ChallengeApp
{
    public abstract class Person
    {
        protected Person(string name, string surname, char sex, int age)
            : this(name, surname)
        {
            this.Sex = sex;
            this.Age = age; 
        }

        protected Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public int Age { get; private set; }

        public char Sex { get; private set; }
    }
}
