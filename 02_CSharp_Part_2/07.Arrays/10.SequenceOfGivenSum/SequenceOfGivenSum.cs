using System;
using System.Collections.Generic;
/* 10.Write a program that finds in given array of integers
 * a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/



class SequenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter the size of your array: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Enter the desired sum: ");
        int s = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
        int bestStart = -1;
        int bestEnd = 0;

        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < length; j++)
            {
                currentSum += arr[j];
                if (currentSum > s)
                {
                    break;
                }
                else if (currentSum == s)
                {
                    bestStart = i;
                    bestEnd = j;
                }
            }
            if (bestStart > -1)
            {
                break;
            }
        }

        Console.Write("Best sequence: ");
        for (int i = bestStart; i <= bestEnd; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
    }
}

