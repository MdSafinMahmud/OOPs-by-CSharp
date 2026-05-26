using System;

class Program
{
    static void Main(string[] args)
    {
        int num, i, sum = 0;
        Console.Write("Enter number: ");
        num = int.Parse(Console.ReadLine()!);
        for (i = 1; i <= num; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum = " + sum);
    }
}