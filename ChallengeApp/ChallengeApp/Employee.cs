namespace ChallengeApp;
public class Employee
{
    public Employee(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    private List<float> points = new List<float>();

    public void AddPoints(float score)
    {
        if (score >= -100 && score <= 100)
            this.points.Add(score);
        else
            Console.WriteLine("     *** WARNING ***   score " + '"' + score + '"' + " is out of acceptable range (-100 - 100)");
    }

    public void AddPoints(int score)
    {
        this.AddPoints((float)score);
    }

    public void AddPoints(double score)
    {
        if (score < float.MaxValue && score >= float.MinValue)
            this.points.Add((float)Math.Round(score));
        else
            Console.WriteLine("     *** WARNING ***   " + '"' + score + '"' + " is out of range");
    }

    public void AddPoints(string score)
    {
        if (float.TryParse(score, out float result))
            this.AddPoints((float)result);
        else Console.WriteLine("     *** WARNING ***   " + '"' + score + '"' + " is not proper score");
    }

    public float Result
    {
        get
        {
            return this.points.Sum();
        }
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Minimum = points.Min();
        statistics.Maximum = points.Max();
        statistics.Average = points.Average();
        return statistics;
    }

    public List<float> GetPointList()
    {
        return this.points;
    }
}