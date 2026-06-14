using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        int sum = 0;

        Console.WriteLine("Enter 10 elements:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            sum += numbers[i];
        }

        Console.WriteLine("Summation of all elements = " + sum);
    }
}