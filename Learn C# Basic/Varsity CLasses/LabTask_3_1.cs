using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter text for print it's length ");
        string text = Console.ReadLine()!;
        Console.WriteLine($"Length is:{text.Length}");
    }
}