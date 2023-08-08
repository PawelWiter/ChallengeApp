namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }

        //event EmployeeBase.ScoreAddedDelegate ScoreAdded;

        void AddScore(float numberOfScore);

        void AddScore(double numberOfScore);

        void AddScore(int numberOfScore);

        void AddScore(char numberOfScore);

        void AddScore(string numberOfScore);

        Statistics GetStatistics();
    }
}
