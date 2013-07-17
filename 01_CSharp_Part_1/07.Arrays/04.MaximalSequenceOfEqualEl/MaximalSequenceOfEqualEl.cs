using System;
/* 04.Write a program that finds the maximal
 * sequence of equal elements in an array.
 Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/

class MaximalSequenceOfEqualEl
{
    static void Main()
    {
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
            if (array[i] == previous)
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

        for (int i = bestStart; i < bestStart + bestLen ; i++)
        {
            Console.Write(array[i] + ", ");
        }
    }
}

