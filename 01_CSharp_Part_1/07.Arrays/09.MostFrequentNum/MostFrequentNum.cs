using System;
/* 09.Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)*/


class MostFrequentNum
{
    static void Main()
    {
        Console.Write("Enter the size of your array: ");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int times = 0;
        int mostFrequent = 0;

        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            int current = 0;
            for (int j = 0; j < length; j++)
            {
                if (arr[i] == arr[j])
                {
                    current++;
                }
            }

            if (current > times)
            {
                times = current;
                mostFrequent = arr[i];
            }
        } 
        Console.WriteLine("Most frequent: {0}", mostFrequent);
        Console.WriteLine("{0} times", times);
    }
}

