using System.Linq;

namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase    // for the future
    {
        public EmployeeInMemory(string firstName, string lastName, char gender, int age)
        : base(firstName, lastName, gender, age)
        {
        }
        
        protected List<float> points = new List<float>();

        public float result
        {
            get
            {
                return this.points.Sum();
            }
        }

        override public void AddPoints(float score)
        {
            if (score >= -100 && score <= 100)
                this.points.Add(score);
            else
                throw new Exception("score " + '"' + score + '"' + " is out of range (-100 - 100)");
        }

        override public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            if (this.points.Count() == 0)
                throw new Exception("statistics are not available when points list is empty");
            statistics.Minimum = points.Min();
            statistics.Maximum = points.Max();
            statistics.Average = points.Average();
            statistics.Result = points.Sum();
            statistics.points = this.points;
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }

        override public List<float> GetPointList()
        {
            return this.points;
        }
    }
}