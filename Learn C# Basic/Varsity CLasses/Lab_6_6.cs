using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array size: ");
        int n = Convert.ToInt16(Console.ReadLine()!);
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elements{i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine()!);
        }
        int max = arr[0];
        int min = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine($"Maximum Element={max}");
        Console.WriteLine($"Minimum Element={min}");
    }
}