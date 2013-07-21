using System;
/* 02.Write a program that reads a rectangular 
 * matrix of size N x M and finds in it 
 * the square 3 x 3 that has maximal sum of its elements.*/


class MaximalSumOfSquare
{
    //static int n = int.Parse(Console.ReadLine());
    //static int m = int.Parse(Console.ReadLine());
    static int bestSum = int.MinValue;
    static int s = 3;

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
    static int GenerateSum(int[,] matrix, int s, int currentRow, int currentCol)
    {
        int currentSum = 0;

        // looping the matrix only in 3x3 square
        for (int i = 0; i < s; i++)
        {
            for (int j = 0; j < s; j++)
            {
                currentSum += matrix[currentRow + i, currentCol + j];
            }
        }
        return currentSum;
    }
    static void Main()
    {
        int[,] matrix = {{2, 4, 5, 6, 7, 12},
                         {3, 8, 12, 3, 5, 6},
                         {4, 12, 7, 3, 2, 1},
                         {5, 18, 4, 3, 6, 12}};
        int maxCol = -1, maxRow = -1;

        for (int i = 0; i < matrix.GetLength(0) - s + 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - s + 1; j++)
            {
                int currentSum = GenerateSum(matrix, s, i, j);

                if (currentSum > bestSum)
                {
                    // saving current best sum with the start coordinates
                    bestSum = currentSum;
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        // result matrix build
        int[,] result = new int[s, s];

        for (int i = 0; i < s; i++)
        {
            for (int j = 0; j < s; j++)
            {
                result[i, j] = matrix[maxRow + i, maxCol + j];
            }
        }
        PrintMatrix(result);
    }
}

