/*
//Saying hello and name on different lines
string Hello = "Hello and welcome back:";

string Name = "Sebastian Gaarde Thomsen";

Console.WriteLine (Hello + "\n" + Name);

//Code to find a sum of two numbers
int x = 3, y = 7;
Console.WriteLine(x + " + " + y + " = " + (x+y));
Console.WriteLine("{0] + {1} = {2}", x, y, x+y);
Console.WriteLine($"x = {x} + {y}");

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

//Multiplication of three numbers
int m1 = 2, m2 = 3, m3 = 6;
Console.WriteLine(m1 + " * " + m2 + " * " + m3 + " = " + (m1*m2*m3));

//Coding a basic calculator
int number25 = 25, number4 = 4;
Console.WriteLine("{0} + {1} = {2}", number25, number4, number25+number4); //29
Console.WriteLine("{0} - {1} = {2}", number25, number4, number25-number4); //21
Console.WriteLine("{0} * {1} = {2}", number25, number4, number25*number4); //100
Console.WriteLine("{0}/{1} = {2}", number25, number4, number25/number4); //6

//Multiplication table of a number
int g1 = 2;
Console.WriteLine("{0} * {1} = {2}", g1, 0, g1*0); //0
Console.WriteLine("{0} * {1} = {2}", g1, 1, g1*1); //2
Console.WriteLine("{0} * {1} = {2}", g1, 2, g1*2); //4
Console.WriteLine("{0} * {1} = {2}", g1, 3, g1*3); //6

//Find the average to 4 numbers
int n1 = 10, n2 = 15, n3 = 20, n4 = 30;
Console.WriteLine("({0} + {1} + {2} + {3})/{4} = {5}", n1, n2, n3, n4, 4, (n1+n2+n3+n4)/4); //18

//Three number inputs and outputs different calculation results with those numbers
int z1 = 5, z2 = 6, z3 = 7;
Console.WriteLine("({0} + {1}) * {2} = {3}", z1, z2, z3, (z1+z2)*z3); //77
Console.WriteLine("({0} * {1}) + ({1} * {2}) = {3}", z1, z2, z3, (z1*z2)+(z2*z3)); //72

//Take an age as input and prints "you look older than (age)"
int age = 17;
Console.WriteLine("You look older than {0}!", age);

//Take a number and display it four times in a row with separation and no separation
int num;
Console.Write("Write your number: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0} {0} {0} {0}", num);
Console.WriteLine("{0}{0}{0}{0}", num);

//Take number input and display in a rectangle of three columns and five rows
int num0;
Console.Write("Enter digit: ");
num0 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("{0}{0}{0}\n{0} {0}\n{0} {0}\n{0} {0}\n{0}{0}{0}", num0);

//Convert celsius to kelvin and fahrenheit
int celsius = 30;
Console.WriteLine("{0} + 273 = {1}", celsius, celsius+273); //303
Console.WriteLine("{0} * 18/10 + 32 = {1}", celsius, celsius*18/10+32); //86

//Char code
char å = Convert.ToChar(Console.ReadLine());

//Putting the order of letters in reverse
char letter1, letter2, letter3;

Console.Write("Input letter: ");
letter1 = Convert.ToChar(Console.ReadLine());

Console.Write("Input letter: ");
letter2 = Convert.ToChar(Console.ReadLine());

Console.Write("Input letter: ");
letter3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("{0} {1} {2}", letter3, letter2, letter1);

//Take the radius of a cirkel and find the perimeter and area´
int radius = 12;
Console.WriteLine("{0} * 2 * 3,14 = {1}", radius, radius*2*3.14);
Console.WriteLine("{0} * {1} * 3,14 = {2}", radius, radius,radius*radius*3.14);

//Take distance and time input and display speed in km/t
double miles = 31.0685596;
int kilometers = 50; 
float hours = 1.598888f;
Console.WriteLine("{0}/{1} = {2} km/t", kilometers, hours, kilometers/hours); //31,27172
Console.WriteLine("{0}/{1} = {2} mph", miles, hours, miles/hours); //19,4355

//Take the radius of a sphere and calculate + display the surface and the volume
int radius = 2;
Console.WriteLine("4/3 * 3,14 * ({0} * {0} * {0}) = {1}", radius, 1.33*3.14*(radius*radius*radius)); //33,51032
Console.WriteLine("4 * 3,14 * ({0} * {0}) = {1}", radius, 4*3.14*(radius*radius)); //50,26548

//Get the terminal to say 5 and 5 are equal
int x1 = 7, y1 = 7;
if (x1 == y1) {
    Console.WriteLine(x1 + " and " + y1 + " are equal");
}
else {
    Console.WriteLine(x1 + " and " + y1 +  " are not equal");
}

//Check if a number is even or odd
int digit;
Console.Write("Enter digit: ");
digit = Convert.ToInt32(Console.ReadLine());

if (digit % 2 == 0) {
    Console.WriteLine("Even");
} 
else {
    Console.WriteLine("Odd");
}

//Check if a number is positive or negative

int digit0;
Console.Write("Enter digit: ");
digit0 = Convert.ToInt32(Console.ReadLine());

if (digit0 > 0) {
    Console.WriteLine("{0} is a positive number", digit0);
}
else if (digit0 < 0) {
    Console.WriteLine("{0} is a negative number", digit0);
}
else {
    Console.WriteLine("{0}, aka the number 0 (nothing)", digit0);
}

//Check if a year is a leap year
int year;
Console.Write("Insert year: ");
year = Convert.ToInt32(Console.ReadLine());

if ((year % 4) == 0) {
    Console.WriteLine("{0} is a leap year", year);
}
else {
    Console.WriteLine("{0} is not a leap year", year);
}

//Find out if a candidate is allowed to vote considering their age
int candidate;
Console.Write("State you age, candidate: ");
candidate = Convert.ToInt32(Console.ReadLine());

if (candidate >= 18) {
    Console.WriteLine("Congratulations, you are allowed to vote!");
}
else {
    Console.WriteLine("Apologies, you may not vote.");
}

//Find out if a number is postive or negative with 1, 0 and -1
int m0;
Console.Write("Enter a single degit: ");
m0 = Convert.ToInt32(Console.ReadLine());

if (m0 > 0) {
    Console.WriteLine("n is 1");
}
else if (m0 < 0) {
    Console.WriteLine("n is -1");
}
else {
    Console.WriteLine("n is 0");
}

//Catagorize people according to their height
int height;
Console.Write("Tell me your height: ");
height = Convert.ToInt32(Console.ReadLine());

if (height < 147) {
    Console.WriteLine("Your either a dwarf or a child.");
}
else if (height == 175) {
    Console.WriteLine("Congrats, your an average man or tall woman");
}
else if (height == 163) {
    Console.WriteLine("Congrats, your an avereage woman og short man");
}
else if (height >= 180) {
    Console.WriteLine("Your tall");
}
else if (height <= 160) {
    Console.WriteLine("Shorty");
}

//Finding the largest out of three numbers
int largest1, largest2, largest3;

Console.Write("Input the first number :");
largest1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the  second number :");
largest2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the third number :");
largest3 = Convert.ToInt32(Console.ReadLine());

if (largest1 > largest2) {
    if (largest1 > largest3){
        Console.WriteLine("The first number ({0}) is the largest number.", largest1);
    }
    else {
        Console.WriteLine("The third number ({0}) is the largest number.", largest3);
    }
}
else if (largest2 > largest3) {
    Console.WriteLine("The second number ({0}) is the largest number.", largest2);
    if (largest2 < largest3) {
        Console.WriteLine("The third number ({0}) is the largest number.", largest3);
    }
}

//Find out which quadrant a set of coordinates belong to
int kx, ky;
Console.Write("Input first coordinate: ");
kx = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second coordinate: ");
ky = Convert.ToInt32(Console.ReadLine());

if (kx > 0) {
    if (ky > 0) {
        Console.WriteLine("The coordinate point ({0},{1}) is in quadrant 1", kx, ky);
    }
    else if (ky < 0) {
        Console.WriteLine("The coordinate point ({0},{1}) is in quadrant 4", kx, ky);
    }
}
else if (kx < 0) {
    if (ky > 0) {
        Console.WriteLine("The coordinate point ({0},{1}) is in quadrant 2", kx, ky);
    }
    else if (ky < 0) {
        Console.WriteLine("The coordinate point ({0},{1}) is in quadrant 3", kx, ky);
    }
}
*/
//Find out if people are eligible to enter a proffessional course based on certain criteria
int math, phys, chem, total;
Console.Write("Write your marks in mathematics: ");
math = Convert.ToInt32(Console.ReadLine());
Console.Write("Write your marks in physics: ");
phys = Convert.ToInt32(Console.ReadLine());
Console.Write("Write your marks in chemistry: ");
chem = Convert.ToInt32(Console.ReadLine());
Console.Write("Write you total marks: ");
total = Convert.ToInt32(Console.ReadLine());

if (math >= 65) {
    if (phys >= 55) {
        if (chem >= 50) {
            if (total >= 180) {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
        else {
            Console.WriteLine("The candidate is not eligible for admission.");
        }

    }
    else {
        Console.WriteLine("The candidate is not eligible for admission.");
    }
}
else {
    Console.WriteLine("The candidate is not eligible for admission.");
}