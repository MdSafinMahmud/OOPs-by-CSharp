using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine()!);

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine()!);
        }

        Console.Write("Enter element to search: ");
        int search = Convert.ToInt32(Console.ReadLine()!);

        bool found = false;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == search)
            {
                Console.WriteLine($"Element found at position {i + 1}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Element not found.");
        }
    }
}