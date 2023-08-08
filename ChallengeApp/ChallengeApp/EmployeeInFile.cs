namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public override event ScoreAddedDelegate ScoreAdded;

        private const string filename = "grades.txt";

        public EmployeeInFile(string name, string surname)
        : base(name, surname)
        {
        }

        public override void AddScore(float numberOfScore)
        {
            if (numberOfScore >= 0 && numberOfScore <= 100)
            {
                using var writer = File.AppendText(filename);
                writer.WriteLine(numberOfScore);
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

        public override void AddScore(char result1)
        {
            switch (result1)
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
            var listOfSchoolScore = new[] { "1", "2", "3", "4", "5", "6", "+1", "1+", "2-", "-2", "2+", "+2", "3-", "-3", "3+", "+3", "4-", "-4", "4+", "+4", "5-", "-5", "5+", "+5", "-6", "6-" };
            if (_ = listOfSchoolScore.Contains(numberOfScore))
            {
                float correctionValue;

                if (numberOfScore.Contains('+'))
                {
                    numberOfScore = numberOfScore.Replace("+", "");
                    correctionValue = 5f;
                }
                else if (numberOfScore.Contains('-'))
                {
                    numberOfScore = numberOfScore.Replace("-", "");
                    correctionValue = -5f;
                }
                else
                {
                    correctionValue = 0f;
                }

                switch (numberOfScore)
                {
                    case "6":
                        this.AddScore(100f + correctionValue);
                        break;
                    case "5":
                        this.AddScore(80f + correctionValue);
                        break;
                    case "4":
                        this.AddScore(60f + correctionValue);
                        break;
                    case "3":
                        this.AddScore(40f + correctionValue);
                        break;
                    case "2":
                        this.AddScore(20f + correctionValue);
                        break;
                    case "1":
                        this.AddScore(0f + correctionValue); ;
                        break;
                    default:
                        throw new Exception("#error: probably wrong grade entered");
                }
            }
            else if (float.TryParse(numberOfScore, out float result))
            {
                this.AddScore(result);
            }
            else if (char.TryParse(numberOfScore, out char result1))
            {
                this.AddScore(result1);
            }
            else
            {
                throw new Exception("#error: entered string is not a float");
            }
        }

        public override Statistics GetStatistics()
        {
            var scoresFromFile = ReadScoresFromFile();
            var result = this.CountStatistics(scoresFromFile);
            return result;
        }

        private List<float> ReadScoresFromFile()
        {
            var scores = new List<float>();
            if (File.Exists($"{filename}"))
            {
                using (var reader = File.OpenText(filename))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        scores.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return scores;
        }

        private Statistics CountStatistics(List<float> scores)
        {
            var statisticsInFile = new Statistics()
            {
                Average = 0,
                Max = float.MinValue,
                Min = float.MaxValue,
                EmptyScoreList = true
            };

            foreach (var score in scores)
            {
                if (score >= 0)
                {
                    statisticsInFile.Max = Math.Max(statisticsInFile.Max, score);
                    statisticsInFile.Min = Math.Min(statisticsInFile.Min, score);
                    statisticsInFile.Average += score;
                    statisticsInFile.EmptyScoreList = false;
                }
            }
            statisticsInFile.Average /= scores.Count;

            statisticsInFile.AverageLetter = statisticsInFile.Average switch
            {
                var average when average >= 80 => 'A',
                var average when average >= 60 => 'B',
                var average when average >= 40 => 'C',
                var average when average >= 20 => 'D',
                _ => 'E',
            };
            return statisticsInFile;
        }
    }
}