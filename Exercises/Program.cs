//Saying hello and name on different lines
string Hello = "Hello and welcome back:";

string Name = "Sebastian Gaarde Thomsen";

Console.WriteLine (Hello + "\n" + Name);

//Code to find a sum of two numbers
int x = 3, y = 7;
Console.WriteLine(x + " + " + y + " = " + (x+y));

//Code to find the result of dividing two numbers
int æ = 6, ø = 2;
Console.WriteLine(æ + "/" + ø + " = " + (æ/ø));

//Code to solve four math problems
int a = -1, b = 4, c = 6;
Console.WriteLine(a + " + " + b + " * " + 6 + " = " + (a+b*c)); //23
int d = 35, e = 5, f = 7;
Console.WriteLine("(" + d + " + " + e + ")" + " % " + f + " = " + ((d+e)%f)); //5
int g = 14, h = -4, i = 6, j = 11;
Console.WriteLine(g + " + " + h + " * " + i + " / " + j + " = " + (g+h*i/j)); //12
int k = 2, l = 15, m = 6, n = 1, o = 7, p = 2;
Console.WriteLine(k + " + " + l + " / " + m + " * " + n + " - " + o + " % " + p + " = " + (k+l/m*n-o%p)); //3

//Swapping two numbers
int number1 = 5;
int number2 = 6;
int temp;

Console.Write("\nInput first number : ");
number1 = int.Parse(Console.ReadLine());

Console.Write("\nInput second number : ");
number2 = int.Parse(Console.ReadLine());

temp = number1;
number1 = number2;
number2 = temp;

Console.Write("\nAfter swapping : ");
Console.Write("\nFirst number : " + number1);
Console.Write("\nSecond number : " + number2);

Console.Read();
