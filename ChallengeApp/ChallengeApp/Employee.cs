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
    private List<int> points = new List<int>();
    public void AddPoints(int score)
    { 
        this.points.Add(score);
    }
    public int Result
    {
        get
        { 
            return this.points.Sum(); 
        }
    }
}
