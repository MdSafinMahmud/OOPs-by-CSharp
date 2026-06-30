using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] matrix =
        {
            {1,2,3},
            {2,1,4},
            {3,2,1}
        };

        Dictionary<int, int> freq = new Dictionary<int, int>();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int num = matrix[i, j];

                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }
        }

        foreach (var item in freq)
        {
            Console.WriteLine($"{item.Key} occurs {item.Value} times");
        }
    }
}