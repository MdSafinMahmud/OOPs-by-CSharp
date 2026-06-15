using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 1, 6 };
        int size = 7;
        Console.WriteLine("Duplicate elements are: ");
        for(int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}