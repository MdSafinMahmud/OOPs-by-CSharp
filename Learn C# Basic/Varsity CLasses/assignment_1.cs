using System;

class Program
{
    static int SecondLargest(int[] arr)
    {
        int largest = arr[0];
        int second = arr[0];

        foreach (int num in arr)
        {
            if (num > largest)
            {
                second = largest;
                largest = num;
            }
            else if (num > second && num != largest)
            {
                second = num;
            }
        }

        return second;
    }

    static void Main()
    {
        int[] arr = { 12, 45, 67, 89, 34 };

        Console.WriteLine("Second Largest = " + SecondLargest(arr));
    }
}