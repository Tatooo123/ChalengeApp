using ChallengeApp;

Employee worker0 = new Employee("Dorothy", "Longbutton", 41);
Employee worker1 = new Employee("Tom", "Jones", 24);
Employee worker2 = new Employee("Susie", "Jones", 29);
Employee worker3 = new Employee("Mark", "Kowalski", 39);
int maxScore = -1;
int maxScoreWorkerIndex = -1;
// Employee maxScoreWorker = null;
List<Employee> workers = new List<Employee>()
{
    worker0, worker1, worker2, worker3 
};
worker0.AddPoints(1);
worker0.AddPoints(4);
worker0.AddPoints(10);
worker0.AddPoints(3);
worker0.AddPoints(6);

worker1.AddPoints(10);
worker1.AddPoints(7);
worker1.AddPoints(2);
worker1.AddPoints(1);
worker1.AddPoints(5);

worker2.AddPoints(1);
worker2.AddPoints(8);
worker2.AddPoints(5);
worker2.AddPoints(3);
worker2.AddPoints(-9);

worker3.AddPoints(3);
worker3.AddPoints(6);
worker3.AddPoints(1);
worker3.AddPoints(9);
worker3.AddPoints(7);
int ii = 0;
foreach (var worker in workers)
{
    if ( worker.Result > maxScore )
    { 
        maxScore = worker.Result;
        maxScoreWorkerIndex = ii;
    }
    Console.WriteLine(ii.ToString().PadLeft(3, ' ') + " - " + workers[ii].FirstName.PadRight(8, ' ') + " " + workers[ii].LastName.PadRight(12, ' ') + " age " + workers[ii].Age.ToString().PadLeft(3, ' ') + " score: " + workers[ii].Result.ToString().PadLeft(3, ' '));
    ii++;
}
Console.WriteLine("------------------");
Console.WriteLine("Max score worker is:");
Console.WriteLine(maxScoreWorkerIndex.ToString().PadLeft(3, ' ') + " - " + workers[maxScoreWorkerIndex].FirstName.PadRight(8, ' ') + " " + workers[maxScoreWorkerIndex].LastName.PadRight(12, ' ') + " age " + workers[maxScoreWorkerIndex].Age.ToString().PadLeft(3, ' ') + " score: " + maxScore.ToString().PadLeft(3, ' '));
