using System;

/* 12. Write a program that reads from the console a positive 
 *integer number N (N < 20) and outputs a matrix like the following:
 * N = 3  N = 4
 * 123    1234
 * 234    2345
 * 345    3456
 *        4567*/

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter \"N\" [N < 20]: ");

        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n + 1, n + 1];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0, num = row + 1; col < matrix.GetLength(1); col++, num++)
            {
                matrix[row, col] = num;
                if (num < 10)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                else
                {
                    Console.Write(matrix[row, col] + " ");
                }
                
            }
            Console.WriteLine();
        }
    }
}

