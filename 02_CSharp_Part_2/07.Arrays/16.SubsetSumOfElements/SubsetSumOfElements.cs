using System;
using System.Collections.Generic;

/*Task 16. We are given an array of integers and a number S. Write a program to find if there exists 
a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)*/

class SubsetSumOfGivenElements
{
    static int[] numsArray = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
    static int sumToFind = int.Parse(Console.ReadLine());

    static int GenerateSum(List<int> subset)
    {
        int result = 0;
        foreach (var item in subset)
        {
            result += item;
        }
        return result;
    }

    static bool Check(List<int> alreadyPrinted, List<int> toBePrinted)
    {
        alreadyPrinted.Sort();
        toBePrinted.Sort();
        bool toPrint = false;
        // prints only subsets with different length
        if (alreadyPrinted.Count != toBePrinted.Count)
        {
            toPrint = true;
        }
        return toPrint;
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
        // the queue holds the subsets
        Queue<List<int>> subsetsQueue = new Queue<List<int>>();
        List<int> emptySet = new List<int>();
        subsetsQueue.Enqueue(emptySet);
        List<int> alreadyPrinted = new List<int>(); // two lists for the subsets
        List<int> toBePrinted = new List<int>();    // to be compared
        bool sumFound = false;

        while (subsetsQueue.Count > 0)
        {
            List<int> subset = subsetsQueue.Dequeue();

            if (GenerateSum(subset) == sumToFind)
            {
                toBePrinted = subset;
                if (Check(alreadyPrinted, toBePrinted))
                {
                    Print(subset);
                    alreadyPrinted = subset;
                    sumFound = true;
                }
            }
            // adding every new subset to the queue
            foreach (var item in numsArray)
            {
                if (! subset.Contains(item))
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