//Task 1
/*
Console.WriteLine("Enter the first number: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
double b = double.Parse(Console.ReadLine());
double c = a + b;
Console.WriteLine($"{a} + {b} = {c}");
*/
//Task 2
/*
Console.WriteLine("Enter the number: ");
int a = int.Parse(Console.ReadLine());
bool isEven = a % 2 == 0;
if (isEven)
{
    Console.WriteLine("The given number is even");
}
else
{
    Console.WriteLine("The given number is odd");
}
*/
//Task 3
/*
Console.WriteLine("Enter the number: ");
int a = int.Parse(Console.ReadLine());
bool isPositive = a > 0;
bool isNegative = a < 0;
bool isZero = a == 0;
if (isPositive)
{
    Console.WriteLine("The given number is positive");
}
else if (isNegative)
{
    Console.WriteLine("The given number is negative");
}
else if (isZero)
{
    Console.WriteLine("The given number equals to zero");
}
else
{
    Console.WriteLine("Unexpected value");
}
*/
//Task 4
/*
Console.WriteLine("Enter your age: ");
int a = int.Parse(Console.ReadLine());
switch (a)
{
    case <= 12 when a >= 0: 
        Console.WriteLine("You are a child.");
        break;

    case >= 13 and <= 19: 
        Console.WriteLine("You are a teenager.");
        break;

    case > 19: 
        Console.WriteLine("You are an adult.");
        break;

    default: 
        Console.WriteLine("Invalid age entered.");
        break;
}
*/
//Task 5
/*
Console.WriteLine("Enter the first number: ");
double a = double.Parse(Console.ReadLine()); 
Console.WriteLine("Enter the second number: ");
double b = double.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"{a} is greater than {b}");
}
else if (a < b)
{
    Console.WriteLine($"{b} is greater than {a}");
}
else Console.WriteLine($"{a} equals to {b}");
*/
//Task 6
/*
Console.WriteLine("Enter a number from 1-7");
int a = int.Parse(Console.ReadLine());
switch (a)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}
*/
//Task 7 
/*
Console.WriteLine("Enter the year: ");
int a = int.Parse(Console.ReadLine());
bool isLeapYear = (a % 4 == 0 && a % 100 != 0) || (a % 400 == 0);
if (isLeapYear)
    Console.WriteLine("The given year is a leap year. There are 366 days in this year.");
else
    Console.WriteLine("The given year is not a leap year. There are 365 days in this year.");
*/
//Task 8 
/*
Console.WriteLine("Enter your password: ");
string passwd = Console.ReadLine();
string password = "12345";
if (passwd == password)
    Console.WriteLine("You entered the correct password");
else
    Console.WriteLine("Input invalid");
*/
//Task 9 
/*
Console.WriteLine("Enter the first value: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second value: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third value: ");
double c = double.Parse(Console.ReadLine());
bool isTriangle = (a + b > c) && (b + c > a) && (c + a > b);
if (isTriangle)
    Console.WriteLine("This is a triangle");
else
    Console.WriteLine("This is not a triangle");
*/
//Task 10
/*
Console.WriteLine("Enter the 4-digit number: ");
int a = int.Parse(Console.ReadLine()); // 4-digit number
int b = 0; // the sum of the digits is b 
bool correctInput = a >= 1000 && a <= 9999;//we make sure the user enters a valid 4-digit number, not 5 or more, or less
if (correctInput)
{
    b += a / 1000; // for example here if we give 1234 the output is going to be 1, so we find the first number
    b += (a / 100) % 10; // here a/100 is gonna be 12 and mod 10 is gonna be 2
    b += (a / 10) % 10; // here a/10 is gonna be 123 and mod 10 is gonna be 3
    b += a % 10; // here 1234 mod 10 is gonna be 4 anyways
    Console.WriteLine($"The sum of {a} equals to {b}");
}
else Console.WriteLine("Invalid input");
*/
