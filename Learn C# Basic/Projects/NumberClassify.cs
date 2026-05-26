using System;

class NumClassify
{
    static void Main(string[] args)
    {
        double number;
        Console.Write("Enter a number: ");
        number = double.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("Negative Number");
        }
        else if (number > 0)
        {
            Console.WriteLine("Positive Number");
        }
        else
        {
            Console.WriteLine("The Number is ZERO!");
        }

    }
}