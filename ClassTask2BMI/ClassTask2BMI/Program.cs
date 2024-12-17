Console.Write("Enter weight(Kg): ");
double mass = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter height: ");
double tall = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your age: ");
int age = Convert.ToInt16(Console.ReadLine());

double BMI = (mass / (Math.Pow(tall, 2))) / 100;

Console.WriteLine("-------------------");

string BMIState;

if (BMI < 18.5){
    BMIState = "underweight";
}
else if (BMI >= 18.5 && BMI <= 24.9){
    BMIState = "healthy";
}
else if (BMI >= 25.0 && BMI <= 29.9){
    BMIState = "overweight";
}
else if (BMI >= 30.0){

    BMIState = "obese";
}

Console.WriteLine("-------------------");

string NormalBMI;



    if (age >= 19 && age <= 24)
    {
        NormalBMI = "19-24";
        Console.WriteLine("healthy");
    }
    else if (age >= 25 && age <= 34)
    {
        NormalBMI = "20-25";
        Console.WriteLine("healthy");
    }
    else if (age >= 35 && age <= 44)
    {
        NormalBMI = "21-26";
        Console.WriteLine("healthy");
    }
    else if (age >= 45 && age <= 54)
    {
        NormalBMI = "22-27";
        Console.WriteLine("healthy");
    }
    else if (age >= 55 && age <= 64)
    {
        NormalBMI = "23-28";
        Console.WriteLine("healthy");
    }
    else if (age >= 65)
    {
        NormalBMI = "24-29";
        Console.WriteLine("healthy");
    }


else Console.WriteLine("not healthy");