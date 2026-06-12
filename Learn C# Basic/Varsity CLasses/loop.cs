using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = Convert.ToInt32(Console.ReadLine()!);
        // int i;
        for (int i=0; i <= n; i++)
        {
            Console.WriteLine(n);
        }
    }
}