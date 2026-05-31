using System;

class Program
{
    static void Main(string[] args)
    {
        int year;
        Console.Write("Enter year to check: ");
        year = Convert.ToInt32(Console.ReadLine()!);
        if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 400 == 0)
        {
            Console.WriteLine("It's leap year!");
        }
        else
        {
            Console.WriteLine("It's not leap year!");
        }
    }
}