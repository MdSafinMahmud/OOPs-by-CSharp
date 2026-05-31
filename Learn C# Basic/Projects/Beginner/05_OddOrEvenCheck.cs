using System;

class NumberCheck
{    static void Main(string[] args)

    {
        int number;
        Console.Write("Enter number to check: ");
        number = int.Parse(Console.ReadLine());
        if (number % 2 != 0)
        {
            Console.WriteLine("Number is ODD");
        }
        else
        {
            Console.WriteLine("Number is EVEN");
        }

    }
}