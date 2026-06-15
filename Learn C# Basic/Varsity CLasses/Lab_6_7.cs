using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        int[] even = new int[n];
        int[] odd = new int[n];

        int evenCount = 0;
        int oddCount = 0;

        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine()!);

            if (arr[i] % 2 == 0)
            {
                even[evenCount] = arr[i];
                evenCount++;
            }
            else
            {
                odd[oddCount] = arr[i];
                oddCount++;
            }
        }

        Console.WriteLine("\nEven elements:");
        for (int i = 0; i < evenCount; i++)
        {
            Console.Write(even[i] + " ");
        }

        Console.WriteLine("\n\nOdd elements:");
        for (int i = 0; i < oddCount; i++)
        {
            Console.Write(odd[i] + " ");
        }
    }
}