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
        this.points.Add(score);
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
}