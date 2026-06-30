using System;

class Program
{
    static void RowSum(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }

            Console.WriteLine($"Row {i + 1} Sum = {sum}");
        }
    }

    static void Main()
    {
        int[,] matrix =
        {
            {1,2,3,4},
            {5,6,7,8},
            {2,4,6,8}
        };

        RowSum(matrix);
    }
}