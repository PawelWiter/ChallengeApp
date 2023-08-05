namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => throw new NotImplementedException();

        public string Surname => throw new NotImplementedException();

        public void AddScore(float numberOfScore)
        {
            throw new NotImplementedException();
        }

        public void AddScore(double numberOfScore)
        {
            throw new NotImplementedException();
        }

        public void AddScore(int numberOfScore)
        {
            throw new NotImplementedException();
        }

        public void AddScore(char numberOfScore)
        {
            throw new NotImplementedException();
        }

        void IEmployee.AddScore(string numberOfScore)
        {
            if (float.TryParse(numberOfScore, out float result))
            {
                this.AddScore(result);
            }
            else if (numberOfScore.Length == 1)
            {
                _ = char.TryParse(numberOfScore, result: out char result1);
                this.AddScore(result1);
            }
            else
            {
                throw new Exception("#error: string is not a float");
            }
            //6=>100
            //5=>80
            //4=>60
            //3=>40
            //-3=>35
            //2+=>25
            //+2=>25
            //2=>20
            //1=>0
            //+/-
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
