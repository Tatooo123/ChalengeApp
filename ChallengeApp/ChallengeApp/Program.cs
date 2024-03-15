using ChallengeApp;
//using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Hello in Employee Score application 1.3");
Console.WriteLine("-----------------------------------");

string input;
char workerType = 'N';
List<float> points;
Statistics statistics;

EmployeeInMemory workerMem = new EmployeeInMemory("Mark", "Twain", 'M', 44);
EmployeeInFile workerFil = new EmployeeInFile("Ana", "Kwitowa", 'W', 24);
EmployeeInMemory worker3 = new EmployeeInMemory("", "", ' ', 0);


while (true)
{
    if (workerType == 'N')
    {
        Console.WriteLine("Type 'M' (in Memory) or 'F' (in File) to select employee type.");
        Console.WriteLine("Type 'Q' to exit. ");
        input = Console.ReadLine().ToUpper();

        if (input == "M")
        {
            workerType = 'M';
            Console.WriteLine("Worker in Memory");
            Console.WriteLine(" " + workerMem.FirstName.PadRight(8, ' ') + " " + workerMem.LastName.PadRight(12, ' ') + " gender " + workerMem.Gender + " age " + workerMem.Age.ToString().PadLeft(3, ' '));
        }
        else if (input == "F")
        {
            workerType = 'F';
            Console.WriteLine("Worker in File");
            Console.WriteLine(" " + workerFil.FirstName.PadRight(8, ' ') + " " + workerFil.LastName.PadRight(12, ' ') + " gender " + workerFil.Gender + " age " + workerFil.Age.ToString().PadLeft(3, ' '));
        }
        else if (input == "Q")
            break;
        Console.WriteLine("------------------");
    }
    else
    {
        try
        {
            Console.WriteLine("Write worker score, type 'R' to statistics raport ");
            input = Console.ReadLine().ToUpper();
            if (input == "Q")
                break;
            else if (input == "R")
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Worker summary:");
                if (workerType == 'M')
                {
                    statistics = workerMem.GetStatistics();
                }
                else
                {
                    statistics = workerFil.GetStatistics();
                }
                Console.WriteLine(" - score: " + statistics.Result.ToString().PadLeft(3, ' '));
                Console.WriteLine(" - statistics:            Min         Max       Average      AvLetter");
                Console.Write("                    ");
                Console.Write($"       {statistics.Minimum:N2}");
                Console.Write($"       {statistics.Maximum:N2}");
                Console.Write($"       {statistics.Average:N2}");
                Console.WriteLine($"       {statistics.AverageLetter}");

                Console.WriteLine("");
                Console.WriteLine(" - all accepted punctation:");

                foreach (var score in statistics.points)
                {
                    Console.WriteLine($"    score: {score:N1}");
                }
                Console.WriteLine("------------------");
                workerType = 'N';
            }
            else
            {
                if (workerType == 'M')
                    workerMem.AddPoints(input);
                else if (workerType == 'F')
                    workerFil.AddPoints(input);
                else
                    throw new Exception("unexpected worker type");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception occured: {e.Message}");
        }
    }
}