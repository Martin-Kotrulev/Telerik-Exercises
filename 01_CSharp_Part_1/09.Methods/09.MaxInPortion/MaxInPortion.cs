using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 09.Write a method that return the maximal element in a portion 
 * of array of integers starting at given index. 
 * Using it write another method that sorts
 * an array in ascending / descending order.*/

class MaxInPortion
{
    static int FindsBiggestInArray(int[] arr, int startIndex)
    {
        // Finds the biggest element in the desired interval
        int max = arr[startIndex];
        int bestIndex = -1;
        for (int i = startIndex + 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                bestIndex = i;
            }
        }
        return bestIndex;
    }

    static void SelectionSort(int[] arr, int startIndex)
    {
        // Sorts the array in the desired interval
        int temp = 0;
        for (int i = startIndex; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter the size of your array: ");

        int[] arr = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the start of the portion [0...{0}]: ", arr.Length - 2);
        int startIndex = int.Parse(Console.ReadLine());

        SelectionSort(arr, startIndex);
        int bestIndex = FindsBiggestInArray(arr, startIndex);

        Console.Write("Type \"1\" for Ascending order or \"0\" of Descending: ");
        int sortChoice = int.Parse(Console.ReadLine());

        // Prints the desired interval of elements according to the choice
        switch (sortChoice)
        {
            case 1:
                for (int i = startIndex; i <= bestIndex; i++)
                {
                    Console.Write(i == bestIndex ? "{0}\n" : "{0}, ", arr[i]);
                }
                break;
            case 0:
                for (int i = bestIndex; i >= startIndex; i--)
                {
                    Console.Write(i == startIndex ? "{0}\n" : "{0}, ", arr[i]);
                }
                break;
            default:
                break;
        }

    }
}

