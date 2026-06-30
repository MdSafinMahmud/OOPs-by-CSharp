using System;

class Program
{
    static int PrimaryDiagonalSum(int[,] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }

    static int SecondaryDiagonalSum(int[,] matrix)
    {
        int sum = 0;
        int n = matrix.GetLength(0);

        for (int i = 0; i < n; i++)
        {
            sum += matrix[i, n - 1 - i];
        }

        return sum;
    }

    static void Main()
    {
        int[,] matrix =
        {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        Console.WriteLine("Primary Diagonal Sum = " + PrimaryDiagonalSum(matrix));
        Console.WriteLine("Secondary Diagonal Sum = " + SecondaryDiagonalSum(matrix));
    }
}