using System;
/* 05.Write a program that finds the maximal increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/


class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        int bestLen = 0;

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int previous = array[0];
        int currentSequence = 1;
        int bestStart = 0;

        for (int i = 1; i < length; i++)
        {
            if (array[i] > previous)
            {
                currentSequence++;
                previous = array[i];
                if (currentSequence > bestLen)
                {
                    bestLen = currentSequence;
                    bestStart = i - bestLen + 1;
                }
            }
            else
            {
                previous = array[i];
                currentSequence = 1;
            }
        }

        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(array[i] + ", ");
        }
    }
}

