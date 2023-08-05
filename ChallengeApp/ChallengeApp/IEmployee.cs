namespace ChallengeApp
{
    //Co..??
    public interface IEmployee
    {
        //CO?
        string Name { get; }
        string Surname { get; }

        void AddScore(float numberOfScore);

        void AddScore(double numberOfScore);

        void AddScore(int numberOfScore);

        void AddScore(char numberOfScore);

        void AddScore(string numberOfScore);

        Statistics GetStatistics();
    }
}
