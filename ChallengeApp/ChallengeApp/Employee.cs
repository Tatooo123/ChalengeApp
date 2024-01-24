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
        else Console.WriteLine("     *** WARNING ***   " + '"' + score + '"' + " is not proper score");
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Minimum = points.Min();
        statistics.Maximum = points.Max();
        statistics.Average = points.Average();
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

    public List<float> GetPointList()
    {
        return this.points;
    }
}