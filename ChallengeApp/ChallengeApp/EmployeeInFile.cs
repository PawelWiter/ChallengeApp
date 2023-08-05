namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddScore(float numberOfScore)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(double numberOfScore)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(int numberOfScore)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(char numberOfScore)
        {
            throw new NotImplementedException();
        }

        public override void AddScore(string numberOfScore)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
