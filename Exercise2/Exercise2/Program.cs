// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Write("Enter number: ");
//int num = Convert.ToInt32(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("your number is even");
//}
//else if (num % 2 == 1)
//{
//    Console.WriteLine("your number is odd");
//}

Console.Write("Enter your Name: ");
string Name = Console.ReadLine();

Console.Write("Enter Gender: ");
string Gender = Console.ReadLine();

if (Gender == "male")
{
    Console.WriteLine("Hello Mr. " + Name);
}
else if (Gender == "female")
{
    Console.WriteLine("Hello Ms. " + Name);
}

Console.WriteLine("Are you active? (yes/no)");
string Active = Console.ReadLine();
if (Active == "yes")
{
    Console.WriteLine("Access permitted");
}
else if (Active == "no")
{
    Console.WriteLine("Access denied");
}
