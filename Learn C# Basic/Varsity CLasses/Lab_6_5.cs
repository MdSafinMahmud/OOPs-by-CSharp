using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 1, 6 };
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    break;
                }
            }
        }

        Console.WriteLine($"Duplicate Count =  {count} ");
    }
}