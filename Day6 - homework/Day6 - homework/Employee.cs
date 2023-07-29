﻿namespace Day6___homework
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int numberOfScore)
        {
            this.score.Add(numberOfScore);
        }

        public void AddAnnualScore(int numberOfAnnualScore)
        {
            this.score.Add(numberOfAnnualScore);
        }

        public void AddPenaltyScore(int numberOfPenaltyScore)
        {
            this.score.Add(numberOfPenaltyScore);
        }
        


    }
}
