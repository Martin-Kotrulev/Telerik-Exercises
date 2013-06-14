using System;
/* 14. Write a program that reads a positive integer number N (N < 20)
 * from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
 *	Example for N = 4:
 *      1  2  3  4
 *      12 13 14 5
 *      11 16 15 6
 *      10 9  8  7
*/

class SpiralNumbers
{
    static void Main()
    {
        Console.Write("Enter the size of your spiraling matrix (N < 20): ");
        int n = int.Parse(Console.ReadLine());
        int[,] spiral = new int[n, n];
        int x = 0;
        int y = 0;
        int num = 1;
        byte round = 0;

        // spiral build;
        while (round < n)
        {
            // right:
            for (int i = 0 + round; i < spiral.GetLength(1); i++)
            {
                x = i;
                if (spiral[y, i] == 0)
                {
                    spiral[y, i] = num;
                    num++;
                }
                else
                {
                    x--;
                    break;
                }
            }

            // down:
            for (int i = y + 1; i < spiral.GetLength(0); i++)
            {
                y = i;
                if (spiral[i, x] == 0)
                {
                    spiral[i, x] = num;
                    num++;
                }
                else
                {
                    y--;
                    break;
                }
            }

            // left:
            for (int i = x - 1; i >= 0; i--)
            {
                x = i;
                if (spiral[y, i] == 0)
                {
                    spiral[y, i] = num;
                    num++;
                }
                else
                {
                    x++;
                    break;
                }
            }

            // up:
            for (int i = y - 1; i >= 0; i--)
            {
                y = i;
                if (spiral[y, x] == 0)
                {
                    spiral[y, x] = num;
                    num++;
                }
                else
                {
                    y++;
                    break;
                }
            }
            round++;
        }

        // print the spiral;
        for (int row = 0; row < spiral.GetLength(0); row++)
        {
            for (int col = 0; col < spiral.GetLength(1); col++)
            {
                Console.Write("{0, -4}", spiral[row, col]);
            }
            Console.WriteLine();
        }
    }
}

