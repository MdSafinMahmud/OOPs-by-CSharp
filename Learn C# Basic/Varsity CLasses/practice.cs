using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n % 2 == 0 || n % 5 == 0)
        {
            Console.WriteLine("Multiple of 2 or 5.");
        }
        else
        {
            Console.WriteLine("Not a multiple of 2 OR 5");
        }
    }
}