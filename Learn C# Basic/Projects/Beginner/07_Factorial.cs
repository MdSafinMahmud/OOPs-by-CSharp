using System;

class Program
{
    static void Main(string[] args)
    {
        int num, i;
        long fact = 1;
        Console.Write("Enter number for Factorial: ");
        num = int.Parse(Console.ReadLine()!);
        for (i = 1; i <= num; i++)
        {
            fact *= i;
        }
        Console.WriteLine("Factorial = " + fact);
    }
}