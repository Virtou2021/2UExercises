class Presentation
{
    // static void Main()
    // {
    //     Print("State your name please : ");
    //     Hello("\nHello", Console.ReadLine()!);
    // }

    static void Hello(string y, string x, string z = ", welcome back to Visual Studio Code.")
    {
        Console.Write($"{y} {x}{z}");
    }

    static void Print(string text)
    {
        Console.Write(text);
    }
}