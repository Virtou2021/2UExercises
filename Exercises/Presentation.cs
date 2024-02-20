/*
public class Program
#pragma warning restore CA1050 // Declare types in namespaces
{
    public static void Main( )
    {
        //Instancere arrayen
        int[] numbers = {6, 5, 4, 3, 2, 1};
        
        //Overskriver array, fordi vi skal have 10 pladser
        numbers = new int[10];

        //For loop til at gå igennem numbers array
        //.Length er for at tjekke lændgen på arrayen
        for(int i = 0; i < numbers.Length; i++){
            //Overskriver værdierne på numbers array
            numbers[i] = i;
        }
        //Output: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        
        Console.WriteLine("---------------------");
        
        //Declere og instancere en ny array
        string[] names = {"Sebastian", "Andreas", "Daniel"};
        
        //Bruger [ ] til at specifere et nummer i begge arrays
        Console.WriteLine(numbers[4]+": "+names[2]);
        //Output: 4: Daniel

        Console.WriteLine("---------------------");
        
        //Laver et jagged string array
        string[][] colours = {
            new string[3] {"Red", "Orange", "Yellow"}, // 0
            //              0         1         2
            new string[] {"Blue", "Purple"}, // 1
            //              0         1
            new string[] {"Green"} // 2
            //               0       
        };

        //2d / Multidimensional nummer arrays
        int[,] numberpad = {
            {7, 8, 9}, // 0
            {4, 5, 6}, // 1
            {1, 2, 3} // 2
        //   0  1   2
        };

        Console.WriteLine(numberpad[1, 2]);
        //Output: 6
        
        Console.WriteLine("---------------------");
        
        //Jagged arrays bliver kaldet med [nummer][nummer]
        //.Length giver mændgen af arrays
        Console.WriteLine(colours.Length);
        //Output: 3
        Console.WriteLine(colours[1].Length);
        //Output: 2

        Console.WriteLine("---------------------");

        //2d/ Multidimensional arrays bliver kaldet med [nummer, nummer]
        //.Length giver mændgen af ting i hele arrayet
        Console.WriteLine(numberpad.Length);
        //Output: 9
        Console.WriteLine(numberpad.Length / 3);
        //Output: 3

        Console.WriteLine("---------------------");

        for(int i = 0; i < colours.Length; i++){
            for(int l = 0; l < colours[i].Length; l++){
                Console.Write(colours[i][l] + " ");
            }
            Console.WriteLine();
        }
        /*Output:
        Red Orange Yellow
        Blue Purple
        Green
        */
        /*
        Console.WriteLine("---------------------");

        // 3 er lændgen af rows/columns af 2d array
        for(int i = 0; i < numberpad.Length / 3; i++){
            for(int l = 0; l < numberpad.Length / 3; l++){
                Console.Write(numberpad[i, l]+" ");
            }
            Console.WriteLine();
        }
        /* Output:
        7 8 9
        4 5 6
        1 2 3
        */
        /*
    }
}
*/