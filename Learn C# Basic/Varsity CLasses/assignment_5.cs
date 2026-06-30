using System;

class Program
{
    static bool IsMagicSquare(int[,] matrix)
    {
        int n = matrix.GetLength(0);

        int targetSum = 0;

        for (int j = 0; j < n; j++)
            targetSum += matrix[0, j];

        // Check rows
        for (int i = 0; i < n; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < n; j++)
                rowSum += matrix[i, j];

            if (rowSum != targetSum)
                return false;
        }

        // Check columns
        for (int j = 0; j < n; j++)
        {
            int colSum = 0;

            for (int i = 0; i < n; i++)
                colSum += matrix[i, j];

            if (colSum != targetSum)
                return false;
        }

        // Primary diagonal
        int d1 = 0;
        for (int i = 0; i < n; i++)
            d1 += matrix[i, i];

        // Secondary diagonal
        int d2 = 0;
        for (int i = 0; i < n; i++)
            d2 += matrix[i, n - 1 - i];

        return d1 == targetSum && d2 == targetSum;
    }

    static void Main()
    {
        int[,] matrix =
        {
            {8,1,6},
            {3,5,7},
            {4,9,2}
        };

        if (IsMagicSquare(matrix))
            Console.WriteLine("Magic Square");
        else
            Console.WriteLine("Not Magic Square");
    }
}