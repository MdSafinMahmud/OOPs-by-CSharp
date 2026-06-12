using System;

class Program
{
    static void Main()
    {
        int size=5;
        int[] numbers = { 10, 20, 30, 40, 50 };
        Console.WriteLine("Array Elements are: ");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}