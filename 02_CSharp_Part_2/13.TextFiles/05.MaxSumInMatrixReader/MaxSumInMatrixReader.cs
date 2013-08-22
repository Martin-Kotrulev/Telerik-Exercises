using System;
using System.IO;
/* 05.Write a program that reads a text file containing a 
 * square matrix of numbers and finds in the matrix an 
 * area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. 
 * Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4 ---------->	17
3 7 1 2
4 3 3 2 */

class MaxSumInMatrixReader
{
    static int[,] ReadMatrix()
    {
        using (StreamReader sr = new StreamReader("../../matrix.txt"))
        {
            int n = int.Parse(sr.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = sr.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(numbers[i]);
                }
            }
            return matrix;
        }
    }

    static int GetMaxSubmatrix(int[,] primeMatrix)
    {
        int maxSum = 0;

        for (int i = 0; i < primeMatrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < primeMatrix.GetLength(1) - 1; j++)
            {
                int currentSum = primeMatrix[i, j] + primeMatrix[i, j + 1] +
                    primeMatrix[i + 1, j] + primeMatrix[i + 1, j + 1];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
        }
        return maxSum;
    }

    static void WriteResult(int maxSum)
    {
        using (StreamWriter sw = new StreamWriter("../../output.txt"))
        {
            sw.WriteLine(maxSum);
        }
    }

    static void Main()
    {
        int maxSum = GetMaxSubmatrix(ReadMatrix());
        WriteResult(maxSum);
    }
}

