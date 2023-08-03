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
            if (numberOfScore >= 0 && numberOfScore <= 100)
            {
                this.score.Add(numberOfScore);
            }
            else
            {
                Console.WriteLine("invalid score value");
            }
        }

        public void AddScore(double numberOfScore)
        {
            float numberOfScorseAsFloat = (float)numberOfScore;
            this.AddScore(numberOfScorseAsFloat);
        }

        public void AddScore(int numberOfScore)
        {
            float numberOfScoreAsFloat = numberOfScore;
            this.AddScore(numberOfScoreAsFloat);
        }

        public void AddScore(decimal numberOfScore)
        {
            float numberOfScoreAsDecimal = Convert.ToSingle(numberOfScore);
            this.AddScore(numberOfScoreAsDecimal);
        }

        public void AddScore(long numberOfScore)
        {
            float numberOfScorseAsFloat = numberOfScore;
            this.AddScore(numberOfScorseAsFloat);
        }

        public void AddScore(string numberOfScore)
        {
            if (float.TryParse(numberOfScore, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var score in this.score)
            {
                {
                    statistics.Max = Math.Max(statistics.Max, score);
                    statistics.Min = Math.Min(statistics.Min, score);
                    statistics.Average += score;
                }
            }
            statistics.Average /= this.score.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
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

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < score.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.score[i]);
                statistics.Min = Math.Min(statistics.Min, this.score[i]);
                statistics.Average += this.score[i];
            }
            statistics.Average /= this.score.Count;

            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.score[index]);
                statistics.Min = Math.Min(statistics.Min, this.score[index]);
                statistics.Average += this.score[index];
                index++;
            } while (index < this.score.Count);

            statistics.Average /= this.score.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.score.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.score[index]);
                statistics.Min = Math.Min(statistics.Min, this.score[index]);
                statistics.Average += this.score[index];
                index++;
            }

            statistics.Average /= this.score.Count;

            return statistics;
        }
    }
}