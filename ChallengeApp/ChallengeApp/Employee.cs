namespace ChallengeApp
{
    public class Employee
    {
        private List<float> score = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
              
        public void AddScore(float numberOfScore)
        {
            this.score.Add(numberOfScore);
        }

        public void AddAnnualScore(float numberOfAnnualScore)
        {
            this.score.Add(numberOfAnnualScore);
        }

        public void AddPenaltyScore(float numberOfPenaltyScore)
        {
            this.score.Add(numberOfPenaltyScore);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var score in this.score)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            
            statistics.Average /= this.score.Count;

            return statistics;
        }
    }
}