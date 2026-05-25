using System;

class MathMatics
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers: ");
        int a = int.Parse(Console.ReadLine() ?? "0");
        int b = int.Parse(Console.ReadLine() ?? "0");
        int c = int.Parse(Console.ReadLine() ?? "0");
        int result = a + b + c;
        Console.WriteLine("The result: " + result);
        int result1 = a - b * c;
        Console.WriteLine("The result1: " + result1);
        int result2 = a + b / c;
        Console.WriteLine("The result2: " + result2);
        int result3 = a + b - c;
        Console.WriteLine("The result3: " + result3);
        Console.WriteLine(result);
    }
}