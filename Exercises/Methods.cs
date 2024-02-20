
class Methods
{
    static void Main()
    {
        SubString();
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

    static void NextMethod()
    {
        
    }
}
