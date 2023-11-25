int number = 982891;
string numberAsString = number.ToString();
char[] numbers = numberAsString.ToCharArray();
int[] counters = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
// int val0;
// val0 = Convert.ToInt32("0"); - why always returns 0, not 48

foreach (char letter in numbers)
{
//    counters[Convert.ToInt32(letter) - 48]++;
    counters[letter - '0']++;
}
for (int i = 0; i < counters.Length; i++)
{
    Console.WriteLine(i+" => "+counters[i]);
}