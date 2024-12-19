
using System.ComponentModel.Design.Serialization;

#region Exercise1, Loops:
for (int i1 = 1; i1 <= 10; i1++)
{
    Console.WriteLine("Number: " + i1);
}
#endregion

Console.WriteLine("---------------");

#region Exercise2:

int sum = 0;

for (int i2 = 1; i2 <= 5; i2++)
{
    Console.WriteLine("Number: " + i2);
    sum += i2;
}
Console.WriteLine("sum: "+sum);

#endregion

Console.WriteLine("---------------");

#region Exercise3:

Console.WriteLine("Enter desired Loops: ");
int loopnumber = Convert.ToInt32(Console.ReadLine());
int total = 0;
for (int i3 = 1; i3 <= loopnumber; i3++)
{
    Console.WriteLine($"Type number {i3} to add: ");
    //int numbers = Convert.ToInt32(Console.ReadLine());
    total += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("The total is: "+total);
#endregion


Console.WriteLine("---------------");



#region Exercise4, while:

//while

int num;

Console.WriteLine("Enter a positive number: ");
num = Convert.ToInt32(Console.ReadLine());
while (num < 0)
{
    //statement
    Console.Write($"invalid number {num}, please enter positive number: ");
    num = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"You've entered a valid number: {num}");

#endregion

Console.WriteLine("---------------");



#region Exercise5, arrays:
//datatype[] arrayName= new dataType[];

int[] numbers= new int[4];

numbers[0] = 5;
numbers[1] = 11;
numbers[2] = 14;
numbers[3] = 14;

Console.WriteLine("Index 1: " + numbers[1]);
Console.WriteLine("Length: " + numbers.Length );
#endregion


Console.WriteLine("---------------");



