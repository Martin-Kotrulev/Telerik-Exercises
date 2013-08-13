using System;
using System.Text;
/* 08.Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
*/

class BestSequenceSum
{
    static void Main()
    {
        Console.Write("Enter the size of your array: ");
        int length = int.Parse(Console.ReadLine());

        StringBuilder sequence = new StringBuilder();
        string bestSequence = "";
        int[] arr = new int[length];
        int currentSum = 0;
        int bestSum = 0;

        Console.WriteLine("Enter values for each element:");
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            sequence.AppendFormat("{0} ", arr[i]);
            currentSum += arr[i];

            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                bestSequence = sequence.ToString();
            }
            else if (currentSum <= 0)
            {
                currentSum = 0;
                sequence.Clear();
            }
        }
        Console.WriteLine("Best sequence: {0}", bestSequence);
        Console.WriteLine("Best sum: {0}", bestSum);


    }
}

