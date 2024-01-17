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
    public float Result
    {
        get
        {
            return this.points.Sum();
        }
    }
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
            this.AddPoints((float)Math.Round(score));
        else
            Console.WriteLine("     *** WARNING ***   " + '"' + score + '"' + " is out of range");
    }

    public void AddPoints(string score)
    {
        if (float.TryParse(score, out float result))
            this.AddPoints((float)result);
        else Console.WriteLine("     *** WARNING ***   " + '"' + score + '"' + " is not proper score");
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Minimum = points.Min();
        statistics.Maximum = points.Max();
        statistics.Average = points.Average();
        return statistics;
    }

    public Statistics GetStatisticsWithForEach()
    {
        var statistics = new Statistics();
        foreach (var point in points)
        {
            statistics.CalculateStep(point);
        }
        statistics.Average /= points.Count();
        return statistics;
    }

    public Statistics GetStatisticsWithFor()
    {
        var statistics = new Statistics();
        for (int ii = 0; ii < points.Count; ii++)
        {
            statistics.CalculateStep(points[ii]);
        }
        statistics.Average /= points.Count();
        return statistics;
    }

    public Statistics GetStatisticsWithDoWhile()
    {
        var statistics = new Statistics();
        int ii = 0;
        do
        {
            statistics.CalculateStep(points[ii]);
            ii++;
        }
        while (ii < points.Count);
        statistics.Average /= points.Count();
        return statistics;
    }

    public Statistics GetStatisticsWithWhile()
    {
        var statistics = new Statistics();
        //statistics.Minimum = float.MaxValue;
        //statistics.Maximum = float.MinValue;
        //statistics.Average = 0;
        int ii = 0;
        while(ii < points.Count)
        {
            //if (point < statistics.Minimum) statistics.Minimum = point;
            //if (point > statistics.Maximum) statistics.Maximum = point;
            //statistics.Average += point;
            statistics.CalculateStep(points[ii]);
            ii++;
        }
        statistics.Average /= points.Count();
        return statistics;
    }

    public List<float> GetPointList()
    {
        return this.points;
    }
}