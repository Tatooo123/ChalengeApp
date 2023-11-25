var name = "Jaromir";
var age = 17;
var isWoman = false;

if (isWoman && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine(name + ", lat " + age);
}
else if (!isWoman && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if ((name == "Adam" || name == "Ewa") && age > 1000)
{
    Console.WriteLine("Prawdopodobnie mieszka w Raju");
}
else
{
    Console.WriteLine("Wystąpił wyjątek nieprzewidziany przez algorytm"); 
}
Console.WriteLine("============================================");
Console.WriteLine("imię:    " + name);
if (isWoman)
{
    Console.WriteLine("płeć:    kobieta");
}
else
{
    Console.WriteLine("płeć:    mężczyzna");
}
Console.WriteLine("wiek:    " + age);