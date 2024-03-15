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
            EmployeeInMemory workerMem = new EmployeeInMemory("", "", ' ', 0);

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null) 
                    {
                        workerMem.AddPoints(line);
                        line = reader.ReadLine();
                    }
                }
            }
            return workerMem.GetStatistics();
        }

        public override List<float> GetPointList()
        {
            List<float> points = new List<float>();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        if (float.TryParse(line, out float result) && result >= -100 && result <= 100)
                        {
                            points.Add(result);
                        }
                        else
                            throw new Exception("score " + '"' + line + '"' + " is not proper score");
                        line = reader.ReadLine();
                    }
                }
            }
            return points;
        }
    }
}