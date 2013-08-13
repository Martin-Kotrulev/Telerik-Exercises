using System;
using System.Collections.Generic;
/* 06.Write a program that reads two integer numbers N and K 
 * and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.*/


class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter \"N\", it will serve as a length of the array: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter \"K\", [K<N]: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        int bestSum = 0;
        int currentSum = 0;
        int bestStart = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if ((i + k - 1) < n)
            {
                if (i == 0)
                {
                    for (int j = 0; j < k - 1; j++) // Checking the first sequence;
                    {
                        currentSum += array[j];
                    }
                }
                else
                {
                    // Using the hinted algorithm from the book;
                    currentSum = (currentSum - array[i - 1]) + array[i + k - 1];
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestStart = i; // Saving the starting point of the best sequence;
                }
            }
        }
        Console.Write("Best sum is in sequence: ");

        for (int i = bestStart; i < bestStart + k; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine("Sum: {0}", bestSum);
    }
}

