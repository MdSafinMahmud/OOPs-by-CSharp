using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine()!);
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine()!);
        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine()!);
        double discriminant = (b * b) - (4 * a * c);
        if (discriminant > 0)
        {
            double root1 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            double root2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine($"Root 1(for positive: {root1})");
            Console.WriteLine($"Root 2(for negative: {root2})");
        }
        else
        {
            Console.WriteLine("Roots are imiginary (complex)");
        }
    }
}