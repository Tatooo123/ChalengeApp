using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public EmployeeInFile(string firstName, string lastName, char gender, int age) 
        : base(firstName, lastName, gender, age)
        {
        }

        static string fileName = "_points.txt";

        public override void AddPoints(float score)
        {
            if (score >= -100 && score <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(score);
                }
            }
            else
                throw new Exception("score " + '"' + score + '"' + " is out of range (-100 - 100)");
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.points = new List<float>();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null) 
                    {
                        if (float.TryParse(line, out float result) && result >= -100 && result <= 100)
                        {
                            statistics.points.Add(result);
                        }
                        else
                            throw new Exception("score in file " + '"' + line + '"' + " is not proper score");
                        line = reader.ReadLine();
                    }
                }
            }
            if (statistics.points.Count() == 0)
                throw new Exception("statistics are not available when points list is empty");
            statistics.Minimum = statistics.points.Min();
            statistics.Maximum = statistics.points.Max();
            statistics.Average = statistics.points.Average();
            statistics.Result = statistics.points.Sum();

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
    }
}