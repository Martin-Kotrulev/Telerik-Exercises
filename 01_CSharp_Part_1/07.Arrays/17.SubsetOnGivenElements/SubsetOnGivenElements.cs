using System;
using System.Collections.Generic;
/* Write a program that reads three integer numbers N,
 * K and S and an array of N elements from the console.
 * Find in the array a subset of K elements
 * that have sum S or indicate about its absence.*/


class SubsetOnGivenElements
{
    static int[] numsArray = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
    static bool sumFound = false;
    static int sumToFind = int.Parse(Console.ReadLine());
    static int exactElements = int.Parse(Console.ReadLine());

    static int GenerateSum(List<int> subset)
    {
        int result = 0;
        foreach (var item in subset)
        {
            result += item;
        }
        return result;
    }

    static void Print(List<int> subset)
    {
        Console.Write("Yes {");
        for (int i = 0; i < subset.Count; i++)
        {
            Console.Write(i != subset.Count - 1 ? subset[i] + "+" : "{0}", subset[i]);
        }
        Console.WriteLine("}");
    }

    static void Main()
    {
        Queue<List<int>> subsetsQueue = new Queue<List<int>>();
        List<int> emptySet = new List<int>();
        subsetsQueue.Enqueue(emptySet);
        
        while (subsetsQueue.Count > 0)
        {
            List<int> subset = subsetsQueue.Dequeue();

            if (GenerateSum(subset) == sumToFind)
            {
                if (subset.Count == exactElements)
                {
                    Print(subset);
                    sumFound = true;
                    break;
                }
            }

            foreach (var item in numsArray)
            {
                if (!subset.Contains(item))
                {
                    List<int> newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(item);
                    subsetsQueue.Enqueue(newSubset);
                }
            }
        }
        if (sumFound == false)
        {
            Console.WriteLine("There is no such subset sum!");
        }
    }
}

