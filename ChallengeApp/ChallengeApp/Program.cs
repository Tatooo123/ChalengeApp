int number = 119983830;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();
int[] counters = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

foreach (char letter in letters)
{
    counters[Convert.ToInt32(letter) - Convert.ToInt32('0')]++;
//    counters[letter - '0']++;
}
for (int i = 0; i < counters.Length; i++)
{
    Console.WriteLine(i+" => "+counters[i]);
}
Console.WriteLine("Finish");