using ChallengeApp;
using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Hello in Employee Score application 1.1b");
Console.WriteLine("-----------------------------------");

string input;
char wrkType = 'N';

Employee worker1 = new Employee("Mark", "Twain", 'M', 44);
Supervisor worker2 = new Supervisor("Ana", "Kwitowa", 'W', 24);
Employee worker3 = new Employee("", "", ' ', 0);

while (true)
{
    if (wrkType == 'N')
    {
        Console.WriteLine("Type 'S' (Supervisor) or 'E' (Employee) to select employee job position.");
        Console.WriteLine("Type 'Q' to exit. ");
        input = Console.ReadLine().ToUpper();
        if (input == "S")
        {
            worker3 = worker2;
            wrkType = 'S';
            Console.WriteLine("Worker: Supervisor");
        }
        else if (input == "E")
        {
            worker3 = worker1;
            wrkType = 'E';
            Console.WriteLine("Worker: Employee");
        }
        else if (input == "Q")
            break;
        Console.WriteLine(" " + worker3.FirstName.PadRight(8, ' ') + " " + worker3.LastName.PadRight(12, ' ') + " gender " + worker3.Gender + " age " + worker3.Age.ToString().PadLeft(3, ' '));
        Console.WriteLine("------------------");
    }
    else
    {
        Console.WriteLine("Write worker score, type 'R' to statistics raport ");
        input = Console.ReadLine().ToUpper();
        if (input == "Q")
            break;
        else if (input == "R")
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Worker summary:");
            Console.WriteLine(" - score: " + worker3.Result.ToString().PadLeft(3, ' '));

            var statistics = worker3.GetStatistics();
            Console.WriteLine(" - statistics:            Min         Max       Average      AvLetter");
            Console.Write("                    ");
            Console.Write($"       {statistics.Minimum:N2}");
            Console.Write($"       {statistics.Maximum:N2}");
            Console.Write($"       {statistics.Average:N2}");
            Console.WriteLine($"       {statistics.AverageLetter}");

            Console.WriteLine("");
            Console.WriteLine(" - all accepted punctation:");
            List<float> points = worker3.GetPointList();

            foreach (var score in points)
            {
                Console.WriteLine($"    score: {score:N1}");
            }
            Console.WriteLine("------------------");
            wrkType = 'N';
            worker3 = new Employee("", "", ' ', 0);
        }
        else
            try
            {
                if (wrkType == 'S')
                    worker2.AddPoints(input);
                else if (wrkType == 'E')
                    worker1.AddPoints(input);
                else
                    throw new Exception("unexpected worker type");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured: {e.Message}");
            }
    }
}
