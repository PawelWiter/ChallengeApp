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

            //var index = 0;

            //while (index < this.score.Count) ;
            //{
            //    if (this.score[index] == 1) 
            //    {
            //        break;
            //    }

            //    statistics.Max = Math.Max(statistics.Max, this.score[index]);
            //    statistics.Min = Math.Min(statistics.Min, this.score[index]);
            //    statistics.Average += this.score[index];
            //    index++;
            //} 

            //do
            //{
            //    statistics.Max = Math.Max(statistics.Max, this.score[index]);
            //    statistics.Min = Math.Min(statistics.Min, this.score[index]);
            //    statistics.Average += this.score[index];
            //    index++;
            //} while (index<this.score.Count );

            //foreach (var score in this.score)
            //{
            //    if(score < 0)
            //    {
            //        continue;
            //    }

            //    statistics.Max = Math.Max(statistics.Max, score);
            //    statistics.Min = Math.Min(statistics.Min, score);
            //    statistics.Average += score;
            //}

            foreach (var score in this.score)
            {

                //break
                //continue
                //goto

                //if (score == 1)
                //{
                //    goto here;
                //}

                //if (score >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, score);
                    statistics.Min = Math.Min(statistics.Min, score);
                    statistics.Average += score;
                }
            }


        //here:
            statistics.Average /= this.score.Count;

            return statistics;
        }
    }
}