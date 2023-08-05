namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname) 
        { 
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello! I am {Name} {Surname}");
        }

        public abstract void AddScore(float numberOfScore);

        public abstract void AddScore(double numberOfScore);

        public abstract void AddScore(int numberOfScore);

        public abstract void AddScore(char numberOfScore);

        public abstract void AddScore(string numberOfScore);

        public abstract Statistics GetStatistics();
    }
}
