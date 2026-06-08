using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter celcius temperatur: ");
        double celcius = double.Parse(Console.ReadLine()!);
        double converTofarhenheit = (1.8 * celcius) + 32;
        Console.Write($"Converted to farhenheit: {converTofarhenheit:F2}");
    }
}