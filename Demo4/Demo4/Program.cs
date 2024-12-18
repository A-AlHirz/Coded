
#region AllFunctions
using System.Xml.Linq;

void PrintName()


{
    Console.WriteLine("Abdullah AlHirz");

}

int TotalSum()
{
    int n1 = 5;
    int n2 = 5;
    int n3 = 7;

    int sum = n1 + n2 + n3;
    return sum;

}

double EmployeeSalary()
{
    double Salary, Bounses, sum;
    Salary = 1000;
    Bounses = 500;
    sum = Salary + Bounses;
    return sum;
}

string FullName(string name)
{
    return name; 
}

int FindMax(int numb1 , int numb2)
{

    if (numb1 > numb2)
    {
        return numb1;
    }
    else if (numb1 < numb2)
    {
        return numb2;
    }
    else
    {
        return 1;
    }
}

void sayHello(string name, string gender, int age)
{
    if (age >= 18)
    {
        if (gender == "m")
        {
            Console.WriteLine("Welcome Mr. " + name);
        }
        else
        {
            Console.WriteLine("Welcome Ms. " + name);
        }
    }
    else
    {
        Console.WriteLine("You are too young!");
    }
}

#endregion


#region CallFunctions
PrintName();
Console.WriteLine("Total: " + TotalSum());
Console.WriteLine("--------------");
double TotalSales = 100;
double EmpSalary = EmployeeSalary();
double Final = TotalSales + EmpSalary;
Console.WriteLine("Total Salary: " + Final);

Console.WriteLine("--------------");

Console.WriteLine("Enter Name");
string fname = Console.ReadLine();
Console.WriteLine(FullName(fname));

Console.WriteLine("--------------");


Console.Write("Enter first Number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The max is: "+FindMax(numb1, numb2));

Console.WriteLine("--------------");

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Please enter your gender (m) or (f)");
string gender = Console.ReadLine();

Console.WriteLine("Please enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

#endregion

