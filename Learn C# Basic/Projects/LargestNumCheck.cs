using System;

class LargNum
{
    static void Main(string[] args)
    {
        double x, y, z;
        Console.Write("Enter 1st number:");
        x = double.Parse(Console.ReadLine()!);
        Console.Write("Enter 2nd number:");
        y = double.Parse(Console.ReadLine()!);
        Console.Write("Enter 3rd number:");
        z = double.Parse(Console.ReadLine()!);
        if (x > y && x > z)
        {
            Console.WriteLine("1st Number is The Biggest");
        }
        else if (y > x && y > z)
        {
            Console.WriteLine("2nd Number is The Biggest");
        }
        else if (z > x && z > y)
        {
            Console.WriteLine("3rd Number is The Biggest");
        }
        else
        {
            Console.WriteLine("Please Input number!");
        }
    }
}