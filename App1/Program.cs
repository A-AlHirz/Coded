// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Datatype Var-Name;
string FirstName ;
string LastName ;

int num1, num2;
num1 = 5 ;
num2 = 7 ;
int sum = num1 + num2;

FirstName = "Abdullah";
LastName = "AlHirz";

string N1, N2, N3;
N1 = "3";
N2 = "4";
N3 = "5";

string Total = (Convert.ToInt32(N1)+Convert.ToInt32(N2)+Convert.ToInt32(N3)).ToString();


//Mr.Abdullah AlHirz, your number is: 12.

Console.WriteLine("Mr."+FirstName+" "+LastName+" "+", your number is: "+ sum);
Console.WriteLine("Total is:"+Total);

Console.WriteLine("-------------------");

Console.Write("Enter your Full Name: ");
string FullName=Console.ReadLine();

Console.Write("Enter City: ");
string City = Console.ReadLine();

Console.Write("Welcome "+FullName + " My city is: " + City);

Console.WriteLine("-------------------");

Console.Write("Enter first Number: ");
int numb1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Enter second number: ");
int numb2 =Convert.ToInt16 (Console.ReadLine());

int Tot = numb1+numb2;

Console.Write("Your total is: " + Tot);

Console.WriteLine("-------------------");

Console.WriteLine("Enter Avg");
double avg = Convert.ToDouble(Console.ReadLine());
if (avg >= 50 && avg <= 100)
{
    Console.WriteLine("Pass");
}
else if (avg < 50 && avg >= 0)
{
    Console.WriteLine("Fail");
}
else
{
    Console.WriteLine("Out of range");
}