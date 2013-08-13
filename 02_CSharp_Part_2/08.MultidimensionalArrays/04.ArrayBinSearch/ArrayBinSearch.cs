using System;
using System.Collections.Generic;
/* 04.Write a program, that reads from the console an array
 * of N integers and an integer K, sorts the array and
 * using the method Array.BinSearch()
 * finds the largest number in the array which is ≤ K. */

class ArrayBinSearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        int index = Array.BinarySearch(arr, k);
        Console.WriteLine(index);

        if (index < -1) // in case all the elements in the array are greater than "k"
        {
            Console.WriteLine("Closest to your number {0} is {1}.", k, arr[~index - 1]);
        }
        else if (index >= 0) // in case element "k" exist in the array
        {
            Console.WriteLine("Your number is with index {0}.", index);
        }
        else // in case "k" is greater than any of the elements in the array
        {
            Console.WriteLine("Closest to your number {0} is {1}", k, arr[~index]);
        }
    }
}

