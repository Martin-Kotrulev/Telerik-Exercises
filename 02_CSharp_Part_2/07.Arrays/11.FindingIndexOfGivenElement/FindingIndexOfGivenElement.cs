using System;
using System.Collections.Generic;
/* 11.Write a program that finds the index of given 
 * element in a sorted array of integers by using
 * the binary search algorithm (find it in Wikipedia).*/

class FindingIndexOfGivenElement
{
    static int BinarySearch(int[] arr, int key)
    {
        Array.Sort(arr);
        int min = 0;
        int max = arr.Length - 1;

        while (max >= min)
        {
            int arrMid = (max + min) / 2;

            if (arr[arrMid] < key)
            {
                min = arrMid + 1;
            }
            else if (arr[arrMid] > key)
            {
                max = arrMid - 1;
            }
            else
            {
                return arrMid;
            }
        }
        return -1;
    }
    static void Main(string[] args)
    {
        int[] arr = { 4, 16, 32, 24, 13, 15, 28, 61, 82 };

        Console.Write("Enter a key value to be checked in the array: ");
        int key = int.Parse(Console.ReadLine());
        int test = BinarySearch(arr, key);

        if (test == -1)
        {
            Console.WriteLine("Your key does not exist in the array!");
        }
        else
        {
            Console.WriteLine("Your key has an index of {0}", BinarySearch(arr, key));
        }
    }
}

