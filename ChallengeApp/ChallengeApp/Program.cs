using ChallengeApp;

Employee worker1 = new Employee("Tom", "Jones", 24);
Employee worker2 = new Employee("Susie", "Jones", 29);
Employee worker3 = new Employee("Mark", "Kowalski", 39);
Employee worker4 = new Employee("Dorothy", "Longbutton", 41);
int maxScore = -1;
Employee maxScoreWorker = null;
List<Employee> workers = new List<Employee>()
{ 
    worker1, worker2, worker3, worker4 
};

worker1.AddPoints(10);
worker1.AddPoints(7);
worker1.AddPoints(2);
worker1.AddPoints(1);
worker1.AddPoints(5);

worker2.AddPoints(1);
worker2.AddPoints(8);
worker2.AddPoints(5);
worker2.AddPoints(3);
worker2.AddPoints(9);

worker3.AddPoints(3);
worker3.AddPoints(6);
worker3.AddPoints(1);
worker3.AddPoints(9);
worker3.AddPoints(7);

worker4.AddPoints(1);
worker4.AddPoints(4);
worker4.AddPoints(10);
worker4.AddPoints(3);
worker4.AddPoints(6);

foreach (var worker in workers)
{
    if ( worker.Result > maxScore )
    { 
        maxScore = worker.Result;
        maxScoreWorker = worker;
    }
}

Console.WriteLine(maxScoreWorker.FirstName + " " + maxScoreWorker.LastName + " age " + maxScoreWorker.Age + " score: " + maxScore);