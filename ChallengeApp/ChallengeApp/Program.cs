using ChallengeApp;

//Console.WriteLine("------------------");
//Console.WriteLine("Hello, I'am Tatooo");
//Console.WriteLine("Program started   ");
//Console.WriteLine("------------------");

Employee worker0 = new Employee("Frank", "Longbutton", 41);
Console.WriteLine("Worker:");
Console.WriteLine(" " + worker0.FirstName.PadRight(8, ' ') + " " + worker0.LastName.PadRight(12, ' ') + " age " + worker0.Age.ToString().PadLeft(3, ' '));
Console.WriteLine("  - AddPoints(10.5F) ");
worker0.AddPoints(10.5F);
Console.WriteLine("  - AddPoints(300) ");
worker0.AddPoints(300);
Console.WriteLine("  - AddPoints(" + '"' + 99 + '"' + ") ");
worker0.AddPoints("99");
Console.WriteLine("  - AddPoints(" + '"' + -101 + '"' + ") ");
worker0.AddPoints("-101");
Console.WriteLine("  - AddPoints(3) ");
worker0.AddPoints(3);
Console.WriteLine("  - AddPoints(" + '"' + "ola" + '"' + ") ");
worker0.AddPoints("ola");

Console.WriteLine("------------------");
Console.WriteLine("Worker summary:");
Console.WriteLine(" - score: " + worker0.Result.ToString().PadLeft(3, ' '));

var statistics = worker0.GetStatistics();
Console.WriteLine(" - statistics:            Min         Max       Average");
Console.Write("    - with Math:    ");
Console.Write(    $"       {statistics.Minimum:N2}");
Console.Write(    $"       {statistics.Maximum:N2}");
Console.WriteLine($"       {statistics.Average:N2}");

statistics = worker0.GetStatisticsWithForEach();
Console.Write("    - WithForEach:  ");
Console.Write(    $"       {statistics.Minimum:N2}");
Console.Write(    $"       {statistics.Maximum:N2}");
Console.WriteLine($"       {statistics.Average:N2}");

statistics = worker0.GetStatisticsWithFor();
Console.Write("    - WithFor:      ");
Console.Write(    $"       {statistics.Minimum:N2}");
Console.Write(    $"       {statistics.Maximum:N2}");
Console.WriteLine($"       {statistics.Average:N2}");

statistics = worker0.GetStatisticsWithDoWhile();
Console.Write("    - WithDoWhile:  ");
Console.Write(    $"       {statistics.Minimum:N2}");
Console.Write(    $"       {statistics.Maximum:N2}");
Console.WriteLine($"       {statistics.Average:N2}");

statistics = worker0.GetStatisticsWithWhile();
Console.Write("    - WithWhile:    ");
Console.Write(    $"       {statistics.Minimum:N2}");
Console.Write(    $"       {statistics.Maximum:N2}");
Console.WriteLine($"       {statistics.Average:N2}");

Console.WriteLine("");
Console.WriteLine(" - all accepted punctation:");
List<float> points = worker0.GetPointList();

foreach (var score in points)
{
    Console.WriteLine($"    score: {score:N1}");
}
Console.WriteLine("------------------");
