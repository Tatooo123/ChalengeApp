using ChallengeApp;
//using static System.Formats.Asn1.AsnWriter;

Console.WriteLine("Hello in Employee Score application 1.3");
Console.WriteLine("-----------------------------------");

string input;
char workerType = 'N';
List<float> points;
Statistics statistics;

EmployeeInMemory workerInMemory = new EmployeeInMemory("Mark", "Twain", 'M', 44);
EmployeeInFile workerInFile = new EmployeeInFile("Ana", "Kwitowa", 'W', 24);
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
            Console.WriteLine(" " + workerInMemory.FirstName.PadRight(8, ' ') + " " + workerInMemory.LastName.PadRight(12, ' ') + " gender " + workerInMemory.Gender + " age " + workerInMemory.Age.ToString().PadLeft(3, ' '));
        }
        else if (input == "F")
        {
            workerType = 'F';
            Console.WriteLine("Worker in File");
            Console.WriteLine(" " + workerInFile.FirstName.PadRight(8, ' ') + " " + workerInFile.LastName.PadRight(12, ' ') + " gender " + workerInFile.Gender + " age " + workerInFile.Age.ToString().PadLeft(3, ' '));
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
                    statistics = workerInMemory.GetStatistics();
                }
                else
                {
                    statistics = workerInFile.GetStatistics();
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
                    workerInMemory.AddPoints(input);
                else if (workerType == 'F')
                    workerInFile.AddPoints(input);
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