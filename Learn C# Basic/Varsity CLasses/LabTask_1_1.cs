using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine()!);
        double pi = 3.1416;
        double area = pi * radius * radius;
        Console.Write($"Area is {area}");
    }
}