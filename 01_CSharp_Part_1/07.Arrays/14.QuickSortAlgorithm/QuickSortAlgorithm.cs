using System;
using System.Collections.Generic;
/* 14. Write a program that sorts an array of strings
 * using the quick sort algorithm (find it in Wikipedia).*/

class QuickSortAlgorithm
{
    static List<int> QuickSort(List<int> unsorted)
    {
        if (unsorted.Count < 1)
        {
            return unsorted;
        }

        // choosing the element called pivot
        // which will serve as a breaking point for two sublists
        int pivot = unsorted.Count / 2;
        int pivotValue = unsorted[pivot];
        unsorted.RemoveAt(pivot);

        List<int> lesser = new List<int>();
        List<int> greater = new List<int>();

        // each element will be compared to the pivot
        // and will be sorted(if smaller to te lesser list, else to the greater) 
        foreach (var element in unsorted)
        {
            if (element <= pivotValue)
            {
                lesser.Add(element);
            }
            else
            {
                greater.Add(element);
            }
        }

        // building the result list by recursively calling
        // QuickSort() for further splitting the sublists;
        List<int> result = new List<int>();
        result.AddRange(QuickSort(lesser));
        result.Add(pivotValue);
        result.AddRange(QuickSort(greater));
        return result;
    }

    static void Main()
    {
        List<int> unsorted = new List<int> { 25, 3, 16, 4, 21, 63, 12, 53, 40 };
        List<int> sorted = QuickSort(unsorted);

        foreach (var value in sorted)
        {
            Console.WriteLine(value);
        }
    }
}

