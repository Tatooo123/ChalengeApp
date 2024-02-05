namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string firstName, string lastName, char gender, int age) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Age = age;
        }
        public string FirstName { get; }
        public string LastName { get; }
        public char Gender { get; }
        public int Age { get; }
    }
}
