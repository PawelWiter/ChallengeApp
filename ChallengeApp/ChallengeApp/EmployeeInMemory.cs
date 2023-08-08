namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event ScoreAddedDelegate ScoreAdded;

        private List<float> scores = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddScore(float numberOfScore)
        {
            if (numberOfScore >= 0 && numberOfScore <= 100)
            {
                this.scores.Add(numberOfScore);

                if (ScoreAdded != null)
                {
                    ScoreAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("#error: value out of range");
            }
        }

        public override void AddScore(double numberOfScore)
        {
            float numberOfScorseAsFloat = (float)numberOfScore;
            this.AddScore(numberOfScorseAsFloat);
        }

        public override void AddScore(int numberOfScore)
        {
            float numberOfScoreAsFloat = numberOfScore;
            this.AddScore(numberOfScoreAsFloat);
        }

        public override void AddScore(char numberOfScore)
        {
            switch (numberOfScore)
            {
                case 'A':
                case 'a':
                    this.AddScore(100f);
                    break;
                case 'B':
                case 'b':
                    this.AddScore(80f);
                    break;
                case 'C':
                case 'c':
                    this.AddScore(60f);
                    break;
                case 'D':
                case 'd':
                    this.AddScore(40f);
                    break;
                case 'E':
                case 'e':
                    this.AddScore(20f);
                    break;
                default:
                    throw new Exception("#error: wrong letter");
            }
        }

        public override void AddScore(string numberOfScore)
        {
            if (float.TryParse(numberOfScore, out float result))
            {
                this.AddScore(result);
            }
            else if (char.TryParse(numberOfScore, out char result1))
            {
                this.AddScore(result1);
            }
            else
            {
                throw new Exception("#error: string is not a float");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var score in this.scores)
            {
                statistics.AddScore(score);
            }

            return statistics;
        }
    }
}