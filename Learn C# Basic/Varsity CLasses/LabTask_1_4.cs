using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter triangle height: ");
        double height = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter triangle Base: ");
        double bAse = double.Parse(Console.ReadLine()!);
        double area = height * bAse / 2;
        Console.WriteLine($"The area of triangle:{area:F2}");

    }
}