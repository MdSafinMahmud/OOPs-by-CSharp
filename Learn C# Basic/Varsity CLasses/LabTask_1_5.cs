using System;

class Program
{
    static void Main(string[] args)
    {
        double x1 = 20;
        double x2 = 30;
        double y1 = 8;
        double y2 = 18;
        double distance = Math.Sqrt(
            Math.Pow(x2 - x1, 2) +
            Math.Pow(y2 - y1, 2)
        );
        Console.WriteLine($"Distance:{distance:F2} ");
    }
}