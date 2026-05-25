using System;

class MathMatics
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers: ");
        int a = int.Parse(Console.ReadLine() ?? "0");
        int b = int.Parse(Console.ReadLine() ?? "0");
        int c = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("The result: ");
        int result = a + b + c;
        Console.WriteLine(result);
    }
}