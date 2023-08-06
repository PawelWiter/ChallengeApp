namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
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
            using var writer = File.AppendText(filename);
            switch (result1)
            {
                case 'A':
                case 'a':
                    writer.WriteLine(100);
                    break;
                case 'B':
                case 'b':
                    writer.WriteLine(80);
                    break;
                case 'C':
                case 'c':
                    writer.WriteLine(60);
                    break;
                case 'D':
                case 'd':
                    writer.WriteLine(40);
                    break;
                case 'E':
                case 'e':
                    writer.WriteLine(20);
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
                    correctionValue = 5;
                }
                else if (numberOfScore.Contains('-'))
                {
                    numberOfScore = numberOfScore.Replace("-", "");
                    correctionValue = -5;
                }
                else
                {
                    correctionValue = 0;
                }

                using var writer = File.AppendText(filename);
                switch (numberOfScore)
                {
                    case "6":
                        writer.WriteLine(100 + correctionValue);
                        break;
                    case "5":
                        writer.WriteLine(80 + correctionValue);
                        break;
                    case "4":
                        writer.WriteLine(60 + correctionValue);
                        break;
                    case "3":
                        writer.WriteLine(40 + correctionValue);
                        break;
                    case "2":
                        writer.WriteLine(20 + correctionValue);
                        break;
                    case "1":
                        writer.WriteLine(0 + correctionValue);
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
            var lineCounter = 0;
            var statistics = new Statistics();
            {
                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;
            };

            if (File.Exists(filename))
            {
                using (var reader = File.OpenText(filename))
                {
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        var number = float.Parse(line);
                        statistics.Max = Math.Max(statistics.Max, number);
                        statistics.Min = Math.Min(statistics.Min, number);
                        statistics.Average += number;
                        lineCounter++;
                    }
                }

                statistics.Average /= lineCounter;
                statistics.AverageLetter = statistics.Average switch
                {
                    var average when average >= 80 => 'A',
                    var average when average >= 60 => 'B',
                    var average when average >= 40 => 'C',
                    var average when average >= 20 => 'D',
                    _ => 'E',
                };
            }
            return statistics;
        }
    }
}
