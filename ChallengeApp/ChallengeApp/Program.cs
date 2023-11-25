var myAge = 58;
int adamsAge = 33;
int newAge;
int maxVal = int.MaxValue;
var countryName = "Patagonia";
string name = "Adam";

Console.WriteLine("Hello there. Clap hands! I'm " + myAge + " years old, but Adam is " + adamsAge);
Console.WriteLine("maxVal " + maxVal);
maxVal = +1;
Console.WriteLine("maxVal " + maxVal + countryName);
newAge = myAge + adamsAge;
Console.WriteLine("newAge " + newAge);
// nw typy danych
Console.WriteLine("--------------------");
//      dla typu bool NIE MA właściwości Min i MaxValue
//      Console.WriteLine("bool    - " + bool.MaxValue + " do " + bool.MinValue);
Console.WriteLine("int     - " + int.MinValue + " do " + int.MaxValue);
Console.WriteLine("uint    - " + uint.MinValue + " do " + uint.MaxValue);
Console.WriteLine("decimal - " + decimal.MinValue + " do " + decimal.MaxValue);
Console.WriteLine("float   - " + float.MinValue + " do " + float.MaxValue);
Console.WriteLine("double  - " + double.MinValue + " do " + double.MaxValue);
Console.WriteLine("char    - " + char.MinValue + " do " + char.MaxValue);
// KONIECZNA zmiana typu danych do porównania lub wykonania operacji
//      Console.WriteLine(decimal.MaxValue > float.MaxValue);
//      Console.WriteLine(decimal.MaxValue + float.MaxValue);

if (adamsAge > 50 && name == "Adam")
{
    Console.WriteLine(" Adam jest starszy niż 50 lat ");
}
else if (name == "Adam")
{
    Console.WriteLine(" Adam nie jest starszy niż 50 lat ");
}
else
{
    Console.WriteLine(" to nie jest Adam");
}