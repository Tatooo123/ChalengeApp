namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase    // for the future
    {
        public EmployeeInMemory(string firstName, string lastName, char gender, int age)
        : base(firstName, lastName, gender, age)
        {
        }

        public override void AddPoints(float score)
        {
            if (score >= -100 && score <= 100)
                this.points.Add(score);
            else
                throw new Exception("score " + '"' + score + '"' + " is out of range (-100 - 100)");
        }
    }
}
