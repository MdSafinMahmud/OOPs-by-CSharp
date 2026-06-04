using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine()!);
        switch (age)
        {
            case >= 0 and <= 2:
                Console.WriteLine("Infant.");
                break;
            case >= 3 and <= 12:
                Console.WriteLine("Child.");
                break;
            case >= 13 and <= 19:
                Console.WriteLine("Teenager.");
                break;
            case >= 20 and <= 64:
                Console.WriteLine("Adult.");
                break;
            case >= 65:
                Console.WriteLine("Senior.");
                break;
            default:
                Console.WriteLine("Senior");
                break;
        }

    }
}