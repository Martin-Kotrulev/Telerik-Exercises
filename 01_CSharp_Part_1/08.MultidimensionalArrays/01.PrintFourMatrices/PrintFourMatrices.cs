using System;
/* 01.Write a program that fills and prints
 * a matrix of size (n, n) as shown below: (examples for n = 4)
 * a) 1 5  9 13 b) 1 8  9 16 c) 7 11 14 16 d) 1 12 11 10
 *    2 6 10 14    2 7 10 15    4 8  12 15    2 13 16  9
 *    3 7 11 15    3 6 11 14    2 5  9  13    3 14 15  8
 *    4 8 12 16    4 5 12 13    1 3  6  10    4 5  6   7 */

class PrintFourMatrices
{
    // the size of the matrices
    static int n = int.Parse(Console.ReadLine());
    static int value = 1;

    static void PrintMatrix(int[,] Matrix)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}", Matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    static void FirstMatrixBulid(int[,] firstMatrix, int value)
    {
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                // ++ used as a postfix first assign the value then iterate!!!
                firstMatrix[row, col] = value++;
            }
        }
        PrintMatrix(firstMatrix);
        Console.WriteLine();
        value = 1;
    }

    static void SecondMatrixBuild(int[,] secondMatrix, int value)
    {
        for (int col = 0; col < n; col++)
        {
            if ((col & 1) == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    secondMatrix[row, col] = value++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    secondMatrix[row, col] = value++;
                }
            }
        }
        PrintMatrix(secondMatrix);
        Console.WriteLine();
    }

    static void ThirdMatrixBuild(int[,] thirdMatrix, int value)
    {
        int row = 0;
        int col = 0;

        //insert values under the main diagonal
        for (int i = n - 1; i >= 0; i--)
        {
            row = i;
            col = 0;
            while (row < n && col < n)
            {
                thirdMatrix[row++, col++] = value++;
            }
        }
        //insert values over the main diagonal
        for (int j = 1; j < n; j++)
        {
            row = j;
            col = 0;
            while (row < n && col < n)
            {
                thirdMatrix[col++, row++] = value++;
            }
        }
        PrintMatrix(thirdMatrix);
        Console.WriteLine();
    }

    static void FourthMatrixBuild(int[,] fourthMatrix, int value)
    {
        int row = 0;
        int col = 0;
        int difference = 0;

        while (difference < n - 1)
        {
            if (difference == 0)
            {
                for (int d = row; d < n - difference; d++)
                {
                    row = d;
                    fourthMatrix[row, col] = value++;
                }
            }
            else
            {
                for (int d = row + 1; d < n - difference; d++)
                {
                    row = d;
                    fourthMatrix[row, col] = value++;
                }
            }
            for (int r = col + 1; r < n - difference; r++)
            {
                col = r;
                fourthMatrix[row, col] = value++;
            }
            for (int u = row - 1; u >= difference; u--)
            {
                row = u;
                fourthMatrix[row, col] = value++;
            }
            difference++;
            for (int l = col - 1; l >= difference; l--)
            {
                col = l;
                fourthMatrix[row, col] = value++;
            }
        }

        PrintMatrix(fourthMatrix);
        Console.WriteLine();
    }
    static void Main()
    {
        int[,] firstMatrix = new int[n, n];
        int[,] secondMatrix = new int[n, n];
        int[,] thirdMatrix = new int[n, n];
        int[,] fourthMatrix = new int[n, n];

        FirstMatrixBulid(firstMatrix, value);
        SecondMatrixBuild(secondMatrix, value);
        ThirdMatrixBuild(thirdMatrix, value);
        FourthMatrixBuild(fourthMatrix, value);
    }
}