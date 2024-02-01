using ChallengeApp;

Console.WriteLine("Hello in Employee Score application");
Console.WriteLine("-----------------------------------");

Employee worker0 = new Employee("Mark", "Twain", 44);
string input;

Console.WriteLine("Worker:");
Console.WriteLine(" " + worker0.FirstName.PadRight(8, ' ') + " " + worker0.LastName.PadRight(12, ' ') + " age " + worker0.Age.ToString().PadLeft(3, ' '));

while (true)
{
    Console.WriteLine("Write worker score, type 'Q' to exit:");
    input = Console.ReadLine();
    if (input == "Q" || input == "q")
        break;
    try
    {
        worker0.AddPoints(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception occured: {e.Message}");
    }
}

Console.WriteLine("------------------");
Console.WriteLine("Worker summary:");
Console.WriteLine(" - score: " + worker0.Result.ToString().PadLeft(3, ' '));

var statistics = worker0.GetStatistics();
Console.WriteLine(" - statistics:            Min         Max       Average      AvLetter");
Console.Write("                    ");
Console.Write(    $"       {statistics.Minimum:N2}");
Console.Write(    $"       {statistics.Maximum:N2}");
Console.Write(    $"       {statistics.Average:N2}");
Console.WriteLine($"       {statistics.AverageLetter}");

Console.WriteLine("");
Console.WriteLine(" - all accepted punctation:");
List<float> points = worker0.GetPointList();

foreach (var score in points)
{
    Console.WriteLine($"    score: {score:N1}");
}
Console.WriteLine("------------------");
