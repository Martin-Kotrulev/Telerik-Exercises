using System;
using System.Collections.Generic;
/* 13. Write a program that sorts an array of integers
 * using the merge sort algorithm (find it in Wikipedia).*/


class MergeSortAlgorithm
{
    static List<int> MergeSort(List<int> unsorted)
    {
        // if the length of the unsorted list is 1 consider it sorted;
        // using "<=" prevents infinite recursion for a zero lenght;
        if (unsorted.Count <= 1)
        {
            return unsorted;
        }

        // splitting the list into two sublists;
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int middle = unsorted.Count / 2;

        for (int i = 0; i < middle; i++)
        {
            left.Add(unsorted[i]);
        }
        for (int i = middle; i < unsorted.Count; i++)
        {
            right.Add(unsorted[i]);
        }

        // recursively call MergeSort() to further split sublists
        // until sublist size is 1;
        left = MergeSort(left);
        right = MergeSort(right);

        // merge the sublists returned from prior calls to MergeSort()
        // and return the resulting merged sublists;
        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else if (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }
        return result;
    }

    static void Main()
    {
        List<int> unsorted = new List<int> { 45, 18, 24, 15, 32, 13, 2, 5 };
        List<int> sorted = MergeSort(unsorted);

        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    }
}

