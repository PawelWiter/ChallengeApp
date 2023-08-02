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
            var statistics1 = new Statistics();
            statistics1.Average = 0;
            statistics1.Max = float.MinValue;
            statistics1.Min = float.MaxValue;

            foreach (var score in this.score)
            {
                statistics1.Max = Math.Max(statistics1.Max, score);
                statistics1.Min = Math.Min(statistics1.Min, score);
                statistics1.Average += score;
            }

            statistics1.Average /= this.score.Count;

            return statistics1;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Average = 0;
            statistics2.Max = float.MinValue;
            statistics2.Min = float.MaxValue;

            for (int i = 0; i < score.Count; i++)
            {
                statistics2.Max = Math.Max(statistics2.Max, this.score[i]);
                statistics2.Min = Math.Min(statistics2.Min, this.score[i]);
                statistics2.Average += this.score[i];
            }
            statistics2.Average /= this.score.Count;

            return statistics2;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Average = 0;
            statistics3.Max = float.MinValue;
            statistics3.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics3.Max = Math.Max(statistics3.Max, this.score[index]);
                statistics3.Min = Math.Min(statistics3.Min, this.score[index]);
                statistics3.Average += this.score[index];
                index++;
            } while (index < this.score.Count);

            statistics3.Average /= this.score.Count;

            return statistics3;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Average = 0;
            statistics4.Max = float.MinValue;
            statistics4.Min = float.MaxValue;

            var index = 0;

            while (index < this.score.Count)
            {
                statistics4.Max = Math.Max(statistics4.Max, this.score[index]);
                statistics4.Min = Math.Min(statistics4.Min, this.score[index]);
                statistics4.Average += this.score[index];
                index++;
            }

            statistics4.Average /= this.score.Count;

            return statistics4;
        }
    }
}