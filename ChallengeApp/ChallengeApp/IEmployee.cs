namespace ChallengeApp
{
    internal interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        char Gender { get; }
        int Age { get; }

        void AddPoints(float score);
        void AddPoints(int score);
        void AddPoints(double score);
        void AddPoints(char score);
        void AddPoints(string score);

        Statistics GetStatistics();

        protected List<float> GetPointList();
    }
}
