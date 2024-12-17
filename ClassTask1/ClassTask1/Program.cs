using System.Reflection;

Console.Write("Enter your Name: ");
string Name = Console.ReadLine();

Console.Write("Enter your language: (en/es/fr/tr) ");
string Language = Console.ReadLine();

if (Language == "en")
{
    Console.WriteLine("Hello " + Name);
}
else if (Language == "es")
{
    Console.WriteLine("Hola " + Name);
}
else if (Language == "fr")
{
    Console.WriteLine("Bonjour " + Name);
}
else if (Language == "tr")
{
    Console.WriteLine("Marhaba " + Name);
}

Console.WriteLine("-------------------");

Console.Write("Enter first Number: ");
int numb1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Enter second number: ");
int numb2 = Convert.ToInt16(Console.ReadLine());

if (numb1 > numb2)
{
    Console.WriteLine(numb1);
}
else if (numb1 < numb2)
{
    Console.WriteLine(numb2);
}

Console.WriteLine("-------------------");

Console.Write("Enter mark: ");
int mark = Convert.ToInt16(Console.ReadLine());

if (mark >= 80)
{
    Console.WriteLine("A");
}
else if (mark >= 70 & mark < 80)
{
    Console.WriteLine("B");
}
else if (mark >= 60 & mark <70)
{
    Console.WriteLine("C");
}
else if (mark >= 50 & mark < 60)
{
    Console.WriteLine("D");
}
else if (mark < 50)
{
    Console.WriteLine("F");
}


