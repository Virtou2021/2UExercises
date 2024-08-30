#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.

using System.ComponentModel.DataAnnotations;

class Methods
{
    static void Main()
    {
        PracticeWhile2();
    }

    static void System()
    {
        Console.WriteLine("Sections:\n1. Addition | 2. Subtraction | 3. Division | 4. Multiplication | 5. Swap two numbers |\n\n6. Even or Uneven | 7. Vote or Not | 8. Eligible for Admission | 9. Leap Year | 10. Profit or Loss |\n\n11. Array Input |\n\n Choose a section: ");
        int x = Convert.ToInt32(Console.ReadLine());

        switch (x)
        {
            case 1:
                Addition();
                break;
            case 2:
                Subtraction();
                break;
            case 3:
                Division();
                break;
            case 4:
                Multiplication();
                break;
            case 5:
                SwapTwoNumbers();
                break;
            case 6:
                EvenOrUneven();
                break;
            case 7:
                VoteOrNot();
                break;
            case 8:
                EligibleForAdmission();
                break;
            case 9:
                LeapYear();
                break;
            case 10:
                ProfitOrLoss();
                break;
            case 11:
                ArrayInput();
                break;
            default:
                Console.WriteLine("Section doesn't exist.");
                break;
        }
    }

    static void Addition()
    {
        Console.Write("x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{x} + {y} = {x + y}\n\n");
    }

    static void Subtraction()
    {
        Console.Write("x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{x} - {y} = {x - y}\n\n");
    }

    static void Division()
    {
        Console.Write("x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{x} / {y} = {x / y}\n\n");
    }

    static void Multiplication()
    {
        Console.Write("x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{x} * {y} = {x * y}\n\n");
    }

    static void SwapTwoNumbers()
    {
        Console.Write("x = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y = ");
        int y = Convert.ToInt32(Console.ReadLine());

        int temp = x;
        x = y;
        y = temp;

        Console.WriteLine($"x = {x}, y = {y}");
    }

    static void EvenOrUneven()
    {
        Console.Write("number = ");
        int x = Convert.ToInt32(Console.ReadLine());

        switch (x % 2)
        {
            case 0:
                Console.WriteLine("Even");
                break;
            case 1:
                Console.WriteLine("Uneven");
                break;
        }
    }

    static void VoteOrNot()
    {
        Console.Write("age = ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Congratulations, you are allowed to vote!");
        }
        else
        {
            Console.WriteLine("Apologies, you are not allowed to vote.");
        }
    }

    static void EligibleForAdmission()
    {
        Console.Write("Write your marks in mathematics: ");
        int math = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write your marks in physics: ");
        int phys = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write your marks in chemistry: ");
        int chem = Convert.ToInt32(Console.ReadLine());

        if (math >= 65 && phys >= 55 && chem >= 50 && (math + phys + chem) >= 180)
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }
    }

    static void LeapYear()
    {
        Console.Write("Write a year: ");
        int Year = Convert.ToInt32(Console.ReadLine());

        switch (Year % 4 == 0)
        {
            case true:
                Console.WriteLine("{0} is a leap year", Year);
                break;
            case false:
                Console.WriteLine("{0} is not a leap year", Year);
                break;
        }
    }

    static void ProfitOrLoss()
    {
        Console.Write("Expenses: ");
        int expense = Convert.ToInt32(Console.ReadLine());
        Console.Write("Profit: ");
        int profit = Convert.ToInt32(Console.ReadLine());

        int difference = profit - expense;
        string result = difference < 0 ? $"There is a {difference} loss" : difference > 0 ? $"There is a {difference} gain" : "There is neither loss nor gain";
        Console.WriteLine(result);
    }

    static void ArrayInput()
    {
        int[] arr = new int[10];

        Console.Write("Input number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Input values of the {n} elements in the array: \n");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        ArrayCalculate(arr, n);
    }

    static void ArrayCalculate(int[] arr, int n, int sum = 0) //Connected to Input method^
    {
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        Console.Write($"The sum of all the elements is : {sum}");
    }

    static void SubString()
    {
        string str = "is Hello, name my Sebastian.";
        SubStringPrint(str);
    }

    static void SubStringPrint(string str) //Connected to SubString method^
    {
        Console.WriteLine(str.Substring(3, 7) + str.Substring(15, 3) + str.Substring(10, 5) + str.Substring(0, 2) + str.Substring(17, 11));
    }

    static void TextToPrint()
    {
        PrintString("Hello World");
    }

    static void PrintString(string text) //Connected to TextToPrint method^
    {
        Console.WriteLine(text);
    }

    static void PersonToPrint()
    {
        PrintPerson();
        PrintPerson("Sebastian");
        PrintPerson("Sebastian", 25);
        PrintPerson(age: 25, name: "Sebastian");
    }

    static void PrintPerson(string name = "Sebastian", int age = 25) //Connected to NamesToPrint method^
    {
        Console.WriteLine($"{name} is {age} years old.");
    }

    static void ReturnValue()
    {
        Printplus(2, 5);
        Printplus(6);
    }

    static void Printplus(int x, int y = 5) //Connected to ReturnValue method^
    {
        Console.WriteLine($"{x} + {y} = {Plus(x, y)}");
    }

    static int Plus(int x, int y) //Connected to Printplus method^
    {
        return x + y;
    }




    static void Welcome() //Opave 1 Methods
    {
        PrintWelcome("Welcome friends");
    }

    static void PrintWelcome(string text) //Connected to Welcome method^
    {
        Console.WriteLine(text);
    }

    static void WelcomeString() //Opave 2 Methods
    {
        string name;
        Console.WriteLine("Write your name: ");
        name = Console.ReadLine();

        PrintFriend(name);
    }

    static void PrintFriend(string name) //Connected to WelcomeString method^
    {
        Console.WriteLine($"Welcome friend {name}!\nHave a nice day!");
    }

    static void TwoNumbers() //Opave 3 Methods
    {
        Console.WriteLine("Write a number: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Write another number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        PrintTwoNumbers(x, y);
    }

    static void PrintTwoNumbers(int x, int y) //Connected to TwoNumbers method^
    {
        Console.WriteLine($"The sum of the two numbers is : {PrintSum(x, y)}");
    }

    static int PrintSum(int x, int y) //Connected to PrintTwoNumbers method^
    {
        return x + y;
    }

    static void SpacesInString() //Opave 4 Methods
    {
        string str;
        Console.WriteLine("Write a string: ");
        str = Console.ReadLine();

        Console.WriteLine($"\"{str}\" contains {SpaceCount(str)} spaces");
    }

    static int SpaceCount(string str) //Connected to SpacesInString method^
    {
        int spcctr = 0;
        string str1;

        for (int i = 0; i < str.Length; i++)
        {
            str1 = str.Substring(i, 1);
            if (str1 == " ")
                spcctr++;
        }

        return spcctr;
    }

    static void ElementSum() //Opave 5 Methods
    {
        int[] arr = new int[10];

        Console.Write("Input number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Input values of the {n} elements in the array: \n");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element - {i} : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine($"The sum of all the elements is : {ArraySum(arr, n)}");
    }

    static int ArraySum(int[] arr, int n, int sum = 0) //Connected to ElementSum method^
    {
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    static void SwapTwoIntegers() //Opave 6 Methods
    {
        int x, y;
        Console.Write("Write a number : ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write another number : ");
        y = Convert.ToInt32(Console.ReadLine());

        SwapIntegers(ref x, ref y);
        Console.WriteLine($"Swapped: x = {x}, y = {y}");
    }

    static void SwapIntegers(ref int x, ref int y) //Connected to SwapTwoIntegers method^
    {
        int temp = x;
        x = y;
        y = temp;
    }

    static void IntToThePowerOfExponent() //Opave 7 Methods
    {
        int x, y;
        Console.Write("Write a number : ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Write the exponent : ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{x} to the power of {y} is : {PowerOf(x, y)}");
    }

    static int PowerOf(int x, int y) //Connected to IntToThePowerOfExponent method^
    {
        int result = 1;

        for (int i = 1; i <= y; i++)
        {
            result *= x;
        }

        return result;
    }

    static void NumberFibonacciSequence() //Opave 8 Methods
    {
        Console.Write("Write a number : ");
        Fibonacci(Convert.ToInt32(Console.ReadLine()!));
    }

    static void Fibonacci(int n) //Connected to NNumberFibonacciSequence method^
    {
        int a = 0, b = 1, c;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{a} ");
            c = a + b;
            a = b;
            b = c;
        }
    }

    static void PrimeNumber() //Opave 9 Methods
    {
        int n;
        Console.Write("Write a number : ");
        n = Convert.ToInt32(Console.ReadLine());

        if (PrimeNumber(n, 2)) // Add the missing argument 'i'
        {
            Console.WriteLine($"{n} is a prime number");
        }
        else
        {
            Console.WriteLine($"{n} is not a prime number");
        }
    }

    static bool PrimeNumber(int n, int i) //Connected to PrimeNumber method^
    {

        if (n % i == 0 || n == 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static void ElementDigitSum() //Opave 10 Methods
    {
        int n;
        Console.Write("Write a number : ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The sum of the individual digits is : {DigitSum(n)}");
    }

    static int DigitSum(int n) //Connected to ElementDigitSum method^
    {
        int sum = 0;

        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }




    static void PrintStudents()
    {
        Printclass("", "", "2.U");
        Printclass("", "", "2.Z", 24);
        Printclass("", "", students: 25);
    }

    static void Printclass(string class1, string class2, string class3 = "2.Y", int students = 18) //Connected to PrintStudents method^
    {
        Console.WriteLine($"{class3} has {students} students.");
    }

    static int MathCalculate()
    {
        int res = Mathing(3, 2);
        Console.WriteLine(res);
        return res;
    }

    static int Mathing(int x, int y)
    {
        int res;

        if (x < 5)
        {
            res = x + y;
        }
        else
        {
            res = x - y;
        }

        return res;
    }




    static void NaturalRecursion() //Opgave 1 Recursion
    {
        Console.Write("How many numbers to print : ");
        int crt = Convert.ToInt32(Console.ReadLine());

        PrintNatural(1, crt);
    }

    static int PrintNatural(int zero, int crt) //Connected to PrintNaturalRecursion Method^
    {
        if (crt < 1)
        {
            return zero;
        }
        crt--;
        Console.Write($" {zero} ");
        return crt + PrintNatural(zero + 1, crt);
    }

    static void ToOneRecursion() //Opgave 2 Recursion
    {
        Console.Write("How many numbers to print : ");
        int crt = Convert.ToInt32(Console.ReadLine());

        ToOne(crt, 1);
        Console.Write("\n\n");
    }

    static int ToOne(int crt, int zero) //Connected to ToOneRecursion Method^
    {
        if (crt < 1)
        {
            return zero;
        }

        Console.Write($" {crt} ");
        crt--;
        return ToOne(crt, zero);
    }

    static void CombinePrime() //Opgave 3 Recursion
    {
        Console.Write("How many numbers to sum : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write($"The sum is : {SumOfTen(1, n)}");
    }

    static int SumOfTen(int min, int max) //Connected to CombinePrime Method^
    {
        return CalcuSum(min, max);
    }

    static int CalcuSum(int min, int val) //Connected to SumOfTen Method^
    {
        if (val == min)
        {
            return val;
        }
        return val + CalcuSum(min, val - 1);
    }

    static void DigitSeparater() //Opgave 4 Recursion
    {
        Console.Write("Input a digit : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write($"The digits in the number {n} are : ");
        Separation(n);
    }

    static void Separation(int n) //Connected to DigitSeparater Method^
    {
        if (n < 10)
        {
            Console.Write($"{n} ");
            return;
        }
        Separation(n / 10);
        Console.Write($"{n % 10} ");
    }

    static void DigitCount() //Opgave 5 Recursion
    {
        Console.Write("Input a digit : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write($"The number of digits in {n} are : {DigitCounter(n, 0)}");
    }

    static int DigitCounter(int n, int no) //Connected to DigitCount Method^
    {
        if (n == 0)
        {
            return no;
        }
        return DigitCounter(n / 10, ++no);
    }

    static void NumberRange() //Opgave 6 Recursion
    {
        Console.Write("Input a digit : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"All even numbers from 1 to {n} are : ");
        OddEvenRange(2, n);
        Console.WriteLine($"\nAll Odd numbers from 1 to {n} are : ");
        OddEvenRange(1, n);
        return;
    }

    static void OddEvenRange(int no, int n) //Connected to NumberRange Method^
    {
        if (n < no)
        {
            return;
        }
        Console.Write($" {no} ");
        OddEvenRange(no + 2, n);
    }

    static int YesNoPrime() //Opgave 7 Recursion
    {
        int no;
        Console.Write("Input a digit : ");
        int n = Convert.ToInt32(Console.ReadLine());
        no = CheckPrime(n, n / 2);

        if (no == 1)
        {
            Console.WriteLine($"{n} is a prime number");
        }
        else
        {
            Console.WriteLine($"{n} is not a prime number");
        }
        return 0;
    }

    static int CheckPrime(int n, int no) //Connected to YesNoPrime Method^
    {
        if (no == 1)
        {
            return 1;
        }
        else
        {
            if (n % no == 0)
            {
                return 0;
            }
            else
            {
                return CheckPrime(n, no - 1);
            }
        }
    }

    static void Palindrome() //Opgave 8 Recursion
    {
        Console.Write("Input a string : ");
        string text = Console.ReadLine();
        bool tf = CheckPalindrome(text);

        if (tf == true)
        {
            Console.WriteLine("The string is Palindrome");
        }
        else
        {
            Console.WriteLine("The string is not Palindrome");
        }
    }

    static bool CheckPalindrome(string text) //Connected to Palindrome Method^
    {
        if (text.Length <= 1)
        {
            return true;
        }
        else
        {
            if (text[0] != text[text.Length - 1])
            {
                return false;
            }
            else
            {
                return CheckPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }

    static void Factorial() //Opgave 9 Recursion
    {
        Console.Write("Input any positive number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        long fact = FactorialCalcu(n);
        Console.WriteLine($"The Factorial of {n} is : {fact}");
    }

    static long FactorialCalcu(int n) //Connected to Factorial Method^
    {
        if (n == 0)
        {
            return 1;
        }
        return n * FactorialCalcu(n - 1);
    }

    static void FibonacciRec() //Opgave 10 Recursion
    {
        Console.Write("Input number of terms for the Fibonacci series : ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{FindFibonacci(i)} ");
        }
    }

    static int FindFibonacci(int n, int p = 0, int q = 1) //Connected to FibonacciRec Method^
    {
        for (int i = 0; i < n; i++)
        {
            int temp = p;
            p = q;
            q = temp + q;
        }
        return p;
    }




    static void ForLoop() //For loop
    {
        Console.Write("Input number of times : ");
        int j = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= j; i++)
        {
            Console.WriteLine("Hello");
        }
    }

    static void NaturalLoop() //Opgave 1 For loops
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i} ");
        }
    }

    static void SumForLoop() //Opgave 2 For loops
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Console.Write($"{i} ");
        }
        Console.WriteLine($"\nThe sum is: {sum}");
    }

    static void SumNaturalN() //Opgave 3 For loops
    {
        int sum = 0;
        Console.Write("Input number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The first {n} natural numbers are: ");

        for (int i = 1; i <= n; i++)
        {
            sum += i;
            Console.Write($"{i} ");
        }
        Console.WriteLine($"\nThe sum is: {sum}");
    }

    static void AverageAndCounter() //OPgave 4 For loops
    {
        int sum = 0;
        Console.WriteLine("Input 10 numbers");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Number-{i}: ");
            int n = Convert.ToInt32(Console.ReadLine());
            sum += n;
        }
        Console.WriteLine($"The average is {sum / 10}");
    }




    static void PracticeWhile() //While loop
    {
        int i = 1;
        while (i < 5)
        {
            Console.WriteLine($"x is {i}");
            i++;
        }
    }

    static void PracticeWhile2() //Do-While loop
    {
        int i = 1;
        do
        {
            Console.WriteLine($"x is {i}");
            i++;
        }
        while (i < 5);
    }
}
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.