namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string firstName, string lastName, char gender, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Age = age;
        }

        public string FirstName { get; private set; }

        public string LastName { get; set; }

        public char Gender { get; set; }

        public int Age { get; set; }

        abstract public void AddPoints(float score);

        public void AddPoints(int score)
        {
            this.AddPoints((float)score);
        }

        public void AddPoints(double score)
        {
            if (score < float.MaxValue && score >= float.MinValue)
                this.AddPoints((float)Math.Round(score));
            else
                throw new Exception("score " + '"' + score + '"' + " is out of range");
        }

        public void AddPoints(char score)
        {
            switch (score)
            {
                case 'A':
                case 'a':
                    this.AddPoints(100);
                    break;
                case 'B':
                case 'b':
                    this.AddPoints(80);
                    break;
                case 'C':
                case 'c':
                    this.AddPoints(60);
                    break;
                case 'D':
                case 'd':
                    this.AddPoints(40);
                    break;
                case 'E':
                case 'e':
                    this.AddPoints(20);
                    break;
                default:
                    this.AddPoints(0);
                    break;
            }
        }

        public void AddPoints(string score)
        {
            if (score.Length == 1)
                this.AddPoints(score[0]);
            else if (float.TryParse(score, out float result))
                this.AddPoints((float)result);
            else
                throw new Exception("score " + '"' + score + '"' + " is not proper score");
        }

        abstract public Statistics GetStatistics();

        abstract public List<float> GetPointList();
    }
}