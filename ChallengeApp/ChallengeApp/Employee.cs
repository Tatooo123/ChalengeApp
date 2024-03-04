using static System.Formats.Asn1.AsnWriter;

namespace ChallengeApp;
public class Employee : IEmployee
{
    public Employee(string firstName, string lastName, char gender, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.gender = gender;
        this.age = age;
    }
    //private string firstName;
    //private string lastName;
    //private char gender;
    //private int age;

    public string FirstName { get; set; }
    //{
    //    get
    //    {
    //        return this.FirstName;
    //    }
    //    set
    //    {
    //        this.FirstName = value;
    //    }
    //}

    public string LastName { get; set; }

    public char Gender { get; set; }

    public int Age { get; set; }

    private List<float> points = new List<float>();

    public float Result
    {
        get
        {
            return this.points.Sum();
        }
    }

    public void AddPoints(float score)
    {
        if (score >= -100 && score <= 100)
            this.points.Add(score);
        else
            throw new Exception("score " + '"' + score + '"' + " is out of range (-100 - 100)");
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
//    public virtual void AddPoints(string score)
    {
        if (score.Length == 1)          
            this.AddPoints(score[0]);
        else if (float.TryParse(score, out float result))
            this.AddPoints((float)result);
        else
            throw new Exception("score " + '"' + score + '"' + " is not proper score");
    }

    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        if (this.points.Count() == 0)
            throw new Exception("statistics are not available when points list is empty");
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