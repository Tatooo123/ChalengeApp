var xName = "Jaromir";
var xAge = 17;
var xIsWoman = false;

if (xIsWoman && xAge < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (xName == "Ewa" && xAge == 33)
{
    Console.WriteLine(xName + ", lat " + xAge);
}
else if (!xIsWoman && xAge < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if ((xName == "Adam" || xName == "Ewa") && xAge > 1000)
{
    Console.WriteLine("Prawdopodobnie mieszka w Raju");
}
else
{
    Console.WriteLine("Wystąpił wyjątek nieprzewidziany przez algorytm!");
}
Console.WriteLine("============================================");
Console.WriteLine("imię:    " + xName);
if (xIsWoman)
{
    Console.WriteLine("płeć:    kobieta");
}
else
{
    Console.WriteLine("płeć:    mężczyzna");
}
Console.WriteLine("wiek:    " + xAge);