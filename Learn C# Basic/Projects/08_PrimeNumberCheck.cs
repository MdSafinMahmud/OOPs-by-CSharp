using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine("Prime Number");
        }
        else
        {
            Console.WriteLine("Not Prime Number");
        }
    }
}