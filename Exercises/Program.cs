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

//Check if a number is even or uneven
int digit;
Console.Write("Enter digit: ");
digit = Convert.ToInt32(Console.ReadLine());

if (digit % 2 == 0) {
    Console.WriteLine("Even");
} 
else {
    Console.WriteLine(Numb");
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
if (height >= 163) {
    if (height <=175) {
    Console.WriteLine("Congrats, your between an average man and woman");
    }
}
if (height >= 180) {
    if (height <=198) {
    Console.WriteLine("Your tall");
    }
}
if (height >= 199) {
    Console.WriteLine("Abnormally tall");
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

//Find out if people are eligible to enter a proffessional course based on certain criteria
int math, phys, chem, total = 180;
Console.Write("Write your marks in mathematics: ");
math = Convert.ToInt32(Console.ReadLine());
Console.Write("Write your marks in physics: ");
phys = Convert.ToInt32(Console.ReadLine());
Console.Write("Write your marks in chemistry: ");
chem = Convert.ToInt32(Console.ReadLine());


if (math >= 65) {
    if (phys >= 55) {
        if (chem >= 50) {
            if ((math+phys+chem) >= total) {
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

//Check whether two ints are equal
int first, second;

Console.Write("First number: ");
first = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
second = Convert.ToInt32(Console.ReadLine());

switch (first == second) {
    case true:
    Console.WriteLine("{0} and {1} are equal", first, second);
    break;
    case false:
    Console.WriteLine("{0} and {1} are not equal", first, second);
    break;
}

//Chech whether a given number is even or Odd
int Numb;

Console.Write("Write your number: ");
Numb = Convert.ToInt32(Console.ReadLine());

switch (Numb % 2) {
    case 0:
    Console.WriteLine("{0} is even", Numb);
    break;
    case 1:
    Console.WriteLine("{0} is odd", Numb);
    break;
}

//Check whether a given number is positive or negative
int PlusMinus;

Console.Write("Write a positive or negative number: ");
PlusMinus = Convert.ToInt32(Console.ReadLine());

switch (PlusMinus) {
    case <= -1:
    Console.WriteLine("{0} is negative", PlusMinus);
    break;
    case >= 1:
    Console.WriteLine("{0} is positive", PlusMinus);
    break;
}

//Find out whether a year is a leap year or not
int Year;

Console.Write("Write a year: ");
Year = Convert.ToInt32(Console.ReadLine());

switch (Year % 4 == 0) {
    case true:
    Console.WriteLine("{0} is a leap year", Year);
    break;
    case false:
    Console.WriteLine("{0} is not a leap year", Year);
    break;
}

//Read the age of a candidate and determine if they are allowed to vote
int CandidateAge;

Console.Write("Candidates age?: ");
CandidateAge = Convert.ToInt32(Console.ReadLine());

switch (CandidateAge >= 21) {
    case true:
    Console.WriteLine("You are able to vote");
    break;
    case false:
    Console.WriteLine("You are not able to vote");
    break;
}

//Read the value of an int and display it with n (1, 0 and -1)
int value;

Console.Write("Type in your value: ");
value = Convert.ToInt32(Console.ReadLine());

switch (value) {
    case < 0:
    Console.WriteLine("The value of n = -1");
    break;
    case > 0:
    Console.WriteLine("The value of n = 1");
    break;
    case 0:
    Console.WriteLine("The value of n = 0");
    break;
}

//Categorize people by height
int height;

Console.Write("Type in your height: ");
height = Convert.ToInt32(Console.ReadLine());

switch (height) {
    case <= 175 and >= 163:
    Console.WriteLine("Your average height");
    break;
    case <= 145:
    Console.WriteLine("Your a dwarf");
    break;
    case >= 176:
    Console.WriteLine("Your tall");
    break;
}

//Figure out which number is the largest of three
int first, second, third;

Console.Write("First number: ");
first = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
second = Convert.ToInt32(Console.ReadLine());
Console.Write("Third number: ");
third = Convert.ToInt32(Console.ReadLine());

if (first > second && first > third) {
    Console.WriteLine("The first number is the largest");
}
else if (first > second && first < third) {
    Console.WriteLine("The shird number is the largest");
}
else if (first < second && first > third) {
    Console.WriteLine("the second number is the largest");
}
else if (second > first && second < third) {
    Console.WriteLine("The third number is the largest");
}
else if (third > first && third < second) {
    Console.WriteLine("The second number is the largest");
}

//Categorize the temperature
int temp;

Console.Write("What's the temperature?: ");
temp = Convert.ToInt32(Console.ReadLine());

switch (temp) {
    case < 0:
    Console.WriteLine("Freezing weather");
    break;
    case >= 0 and < 10:
    Console.WriteLine("Very cold weather");
    break;
    case >= 10 and < 20:
    Console.WriteLine("Cold weather");
    break;
    case >= 20 and < 30:
    Console.WriteLine("Normal");
    break;
    case >= 30 and < 40:
    Console.WriteLine("Hot");
    break;
    case >= 40:
    Console.WriteLine("Very hot");
    break;
}

//Check if a triangle can be formed with given angles
int ang1, ang2, ang3;

Console.Write("Write an angle: ");
ang1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write an angle: ");
ang2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Write an angle: ");
ang3 = Convert.ToInt32(Console.ReadLine());

if (ang1+ang2+ang3 == 180) {
    Console.WriteLine("The triangle is valid");
} else {
    Console.WriteLine("The triangle is not valid");
}

//Write a letter and check if it's a vowel
char ch;
Console.Write("Input a letter (A-Z or a-z): ");
ch = Convert.ToChar(Console.ReadLine().ToLower());

switch (ch) {
    case 'a':
    Console.WriteLine("The letter '{0}' is a vowel", ch);
    break;
    case 'e':
    Console.WriteLine("The letter '{0}' is a vowel", ch);
    break;
    case 'i':
    Console.WriteLine("The letter '{0}' is a vowel", ch);
    break;
    case 'o':
    Console.WriteLine("The letter '{0}' is a vowel", ch);
    break;
    case 'u':
    Console.WriteLine("The letter '{0}' is a vowel", ch);
    break;
    case 'y':
    Console.WriteLine("The letter '{0}' is a vowel", ch);
    break;
    default:
    Console.WriteLine("The letter '{0}' is not a vowel", ch);
    break;
}

//Calculate the loss and profit on a transaction
using System.Diagnostics;

int expense, profit;

Console.Write("Expenses: ");
expense = Convert.ToInt32(Console.ReadLine());
Console.Write("Profit: ");
profit = Convert.ToInt32(Console.ReadLine());

switch (profit-expense) {
    case < 0:
    Console.WriteLine("There is a {0} loss", profit-expense);
    break;
    case > 0:
    Console.WriteLine("There is a {0} gain", profit-expense);
    break;
    case 0:
    Console.WriteLine("There is neither loss nor gain");
    break;
}

//Calculate payment for electricity bill
using System.Reflection.Metadata.Ecma335;

int ID = 1001, Units = 800;
string Name = ("James");

Console.WriteLine("Customer IDNO: {0}", ID);
Console.WriteLine("Customer Name: {0}", Name);
Console.WriteLine("Units Consumed: {0}", Units);
Console.WriteLine("Amount Charges @2.00 per Unit: {0}", Units*2);
Console.WriteLine("Surcharge Amount: {0}", Units*2*0.15);
Console.WriteLine("Net Amount Paid By The Customer: {0}", (Units*2)+(Units*2*0.15));

//Take number 1-7 and display the day as a word
using Microsoft.Win32.SafeHandles;

int Week;
Console.WriteLine("Choose a number between 1 and 7: ");
Week = Convert.ToInt32(Console.ReadLine());

switch (Week) {
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
    Console.WriteLine("Thursdag");
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

//Make code display the first ten natural numbers and find the sum
int j, sum = 0;

for(j=1;j<=10;j++) {
    sum += j;
    Console.Write(j);
}
Console.WriteLine("\nThe sum is {0}", sum);

//Display sum of natural number up to 'n'
int n, sum = 0;
for(n=1;n<=7;n++) {
    sum += n;
    Console.Write(n);
}
Console.WriteLine("\nThe sum is {0}", sum);

//Read ten numbers and find the average and sum
int i, n, sum = 0;
double avg;
for(i=1;i<=10;i++) {
    Console.Write("Number {0}: ", i);
    n = Convert.ToInt32(Console.ReadLine());
    sum += n;
}
avg = sum/10.0;
Console.Write("The sum of ten numbers is {0}\nThe average is {1}", sum, avg);

//Display cube of an int up to a given number
int i, crt;
Console.Write("Input number of terms: ");
crt = Convert.ToInt32(Console.ReadLine());
for(i=1;i<=crt;i++) {
    Console.Write("Number is: {0} and the cube of the {1} is: {2}\n", i, i, (i*i*i));
}

//Display multiplication table of a given int
int i, crt;
Console.Write("Multiplication table of number: ");
crt = Convert.ToInt32(Console.ReadLine());
for(i=1;i<=10;i++) {
    Console.Write("{0} x {1} = {2}\n", crt, i, i*crt);
}

//Display n terms of odd natural numbers and their sums
int i, n, sum = 0;
Console.Write("Input number of terms: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Write("The odd numbers are: ");
for(i=1;i<=n;i++) {
    Console.Write("{0} ", 2*i-1);
    sum += 2*i-1;
}
Console.Write("\nThe sum of odd natural number upto {0} terms is {1}\n", n, sum);

//Display a right triangle with an asterisk
int i, j, rows;
Console.Write("Input number of rows: ");
rows = Convert.ToInt32(Console.ReadLine());
for(i=1;i<=rows;i++){
    for(j=1;j<=i;j++)
        Console.Write("*");
    Console.Write("\n");
}

//Display a right triangle with numbers
int i, j, rows;
Console.Write("Input number of rows: ");
rows = Convert.ToInt32(Console.ReadLine());
for(i=1;i<=rows;i++){
    for(j=1;j<=i;j++)
        Console.Write(j);
    Console.Write("\n");
}

//Write a program that reads a set of integers, and then prints the sum of the even and odd integers
int i1 = 4, i2 = 5, i3 = 120;

while (true) {
    if (i1%2==0) {
        if (i2%2==0) {
            if (i3%2==0) {
                Console.WriteLine("all even and the sum is {0}", i1+i2+i3);
                break;
            }
            else {
                Console.WriteLine("even number {0} and uneven number {1}", i1+i2, i3);
                break;
            }
        }
        else if (i3%2==0) {
            Console.WriteLine("even number {0} and uneven number {1}", i1+i3, i2);
            break;
        }
        else {
            Console.WriteLine("even number {0} and uneven number {1}", i1, i2+i3);
            break;
        }
    }
    else if (i2%2==0) {
        if (i3%2==0) {
            Console.WriteLine("even number {0} and uneven number {1}", i2+i3, i1);
            break;
        }
        else {
            Console.WriteLine("even number {0} and uneven number {1}", i2, i1+i3);
        }
    }
    else if (i3%2==0) {
        Console.WriteLine("even number {0} and uneven number {1}", i3, i1+i2);
        break;
    }
    else {
        Console.WriteLine("all uneven and the sum is {0}", i1+i2+i3);
        break;
    }
}

//Write a loop that asks for two numbers, displays the sum, asks if the loop should be continued or stopped
int numb1, numb2;
bool cont = false;

do {
    Console.WriteLine("Input number: ");
    numb1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number: ");
    numb2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The sum is {0}", numb1+numb2);
    
    Console.WriteLine("\nType 'y' to try again, press another key to stop");
    if (Console.ReadLine() == "y") {
        cont = true;
    } 
    else {
        cont = false;
    }
}
while (cont);

//Project: guess the output
double mathA = 87, danA = 59, engB = 100;

mathA *= 1.03d;
danA *= 1.03d;

switch (mathA) {
    case < 60 and >= 0:
        Console.WriteLine("Falied math");
        break;
    case <= 100 and >= 60:
        Console.WriteLine("Passed math");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
switch (danA) {
    case < 60 and >= 0:
        Console.WriteLine("Failed danish");
        break;
    case <= 100 and >= 60:
        Console.WriteLine("Passed danish");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}
switch (engB) {
    case < 60 and >= 0:
        Console.WriteLine("Failed english");
        break;
    case <= 100 and >= 60:
        Console.WriteLine("Passed english");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

//Program that stores elements in arrays and prints them
int[] arr = new int[10];
int i;

Console.Write("Input 10 elements in the array: ");
for (i = 0; i < 10; i++)
{
    Console.Write("Element - {0} : ", i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("\nElements in the array are: ");
for (i = 0; i < 10; i++) 
{
    Console.Write("{0} ", arr[i]);
}

//Read n values in an array an display them in reverse order
int[] arr = new int[100];
int i, n;

Console.Write("Input number of elements in the array: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input values of {0} number of elements in the array: \n", n);
for (i = 0; i < n; i++) {
    Console.Write("Element - {0} : ",i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("\nElements in the array are: ");
for (i = 0; i < n; i++) {
    Console.Write("{0} ", arr[i]);
}

Console.Write("\nElements in the array in reverse are: ");
for (i = n - 1; i >= 0; i--) {
    Console.Write("{0} ", arr[i]);
}

//Find the sum of all array elements
int[] arr = new int [100];
int i, n, sum = 0;

Console.Write("Input number of elements: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input values of the {0} elements in the array: \n", n);
for (i = 0; i < n; i++) {
    Console.Write("Element - {0} : ", i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

for (i = 0; i < n; i++) {
    sum += arr[i];
}

Console.Write("The sum of all the elements is : {0}", sum);

//Copy elements from array one to array two
int[] arr1 = new int[100];
int[] arr2 = new int[100];
int i, n;

Console.Write("Input number of elements in the array: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input values of {0} number of elements in the array: \n", n);
for (i = 0; i < n; i++) {
    Console.Write("Element - {0} : ",i);
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}

for (i = 0; i < n; i++) {
    arr2[i] = arr1[i];
}

Console.Write("\nElements in the first array are: ");
for (i = 0; i < n; i++) {
    Console.Write("{0} ", arr1[i]);
}

Console.Write("\nElements copied into the second array are: ");
for (i = 0; i < n; i++) {
    Console.Write("{0} ", arr2[i]);
}

//Count duplicate elements in an array
Console.Write("Input number of elements in the array: ");
int arraySize = 0;
arraySize = Convert.ToInt32(Console.ReadLine());

int[] arrayInt = new int[arraySize];

Console.Write($"Input {arraySize} elements in the array : \n");
for(int i = 0; i < arrayInt.Length; i++) {
    Console.Write($"Element - {i} : ");
    arrayInt[i] = Convert.ToInt32(Console.ReadLine());
}

int duplicates = 0;

for (int i = 0; i < arrayInt.Length - 1; i++) {
    for (int j = i + 1; j < arrayInt.Length; j++) {
        if (arrayInt[i] == arrayInt[j]) {
            duplicates++;
            break;
        }
    }
}

Console.WriteLine("Number of duplicate elements foun in the array is: {0}", duplicates);

//Print all unique elements in an array
int n, ctr = 0;
int[] arr = new int[100];
int i, j, k;

Console.Write("Input number of elements: ");
n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input values of {0} number of elements in the array: \n", n);
for (i = 0; i < n; i++) {
    Console.Write("Element - {0} : ",i);
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("\nThe unique elements found in the array are: \n");
for (i = 0; i < n; i++) {
    ctr = 0;

    for (j = 0; j < i - 1; j++) {
        if (arr[i] == arr[j]){
            ctr++;
        }
    }

    for (k = i + 1; k < n; k++) {
        if (arr[i] == arr[k]) {
            ctr++;
        }

        if (arr[i] == arr[i+1]) {
            i++;
        }
    }

    if (ctr == 0) {
        Console.Write("{0} ", arr[i]);
    }
}

//Merge two arrays of the same size according to ascending order
int[] arr1 = new int[100];
int[] arr2 = new int[100];
int[] arr3 = new int[200];
int s1, s2, s3;
int i, j, k;

Console.Write("Input number of elements in the array: ");
s1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input values of {0} number of elements in the array: \n", s1);
for (i = 0; i < s1; i++) {
    Console.Write("Element - {0} : ",i);
    arr1[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("\nInput number of elements in the array: ");
s2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input values of {0} number of elements in the array: \n", s2);
for (i = 0; i < s2; i++) {
    Console.Write("Element - {0} : ",i);
    arr2[i] = Convert.ToInt32(Console.ReadLine());
}

s3 = s1 + s2;

for (i = 0; i < s1; i++) {
    arr3[i] = arr1[i];
}

for (j = 0; i < s2; j++) {
    arr3[i] = arr2[j];
    i++;
}

for (i = 0; i < s3; i++) {
    for (k = 0; k < s3; k++) {
        if (arr3[k] >= arr3[k+1]) {
            j = arr3[k+1];
            arr3[k+1] = arr3[k];
            arr3[k] = j;
        }
    }
}

Console.Write("The merged array in ascending order is: \n");
for (i = 0; i < s3; i++) {
    Console.Write($"{arr3[i]} ");
}
*/