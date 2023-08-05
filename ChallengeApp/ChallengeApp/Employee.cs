namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> score = new List<float>();
        

        public Employee(string name, string surname)
            : base(name, surname)
        {
        }

        public void AddScore(float numberOfScore)
        {
            if (numberOfScore >= 0 && numberOfScore <= 100)
            {
                this.score.Add(numberOfScore);
            }
            else
            {
                throw new Exception("#error: value out of range");
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

        public void AddScore(char numberOfScore)
        {
            switch (numberOfScore)
            {
                case 'A':
                case 'a':
                    this.score.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.score.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.score.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.score.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.score.Add(20);
                    break;
                default:
                    throw new Exception("#error: wrong letter");
            }
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
            else if (numberOfScore.Length == 1)
            {
                char.TryParse(numberOfScore, result: out char result1);
                this.AddScore(result1);
            }
            else
            {
                throw new Exception("#error: string is not a float");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.EmptyScoreList = true;

            foreach (var score in this.score)
            {
                {
                    statistics.Max = Math.Max(statistics.Max, score);
                    statistics.Min = Math.Min(statistics.Min, score);
                    statistics.Average += score;
                    statistics.EmptyScoreList = false;
                }
            }
            statistics.Average /= this.score.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
