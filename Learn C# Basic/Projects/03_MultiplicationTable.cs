using System;

class MultiTable
{
    static void Main(string[] args)
    {
        int x,i;
        Console.Write("Enter number for Multiplication Table: ");
        x = int.Parse(Console.ReadLine()!);
        for (i = 0; i <= 10; i++)
        {
            Console.WriteLine(x + " X " + i + " = " + (x * i));
        }
    }
}