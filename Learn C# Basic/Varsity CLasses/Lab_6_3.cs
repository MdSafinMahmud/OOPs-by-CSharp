using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of the elements: ");
        int n = Convert.ToInt32(Console.ReadLine()!);
        int[] arr = new int[n];
        Console.WriteLine("Enter the array elements");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Elements{i + 1}");
            arr[i] = Convert.ToInt32(Console.ReadLine()!);
        }
        Console.WriteLine("In reverse order.");
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i] + "");
        }
    }
}