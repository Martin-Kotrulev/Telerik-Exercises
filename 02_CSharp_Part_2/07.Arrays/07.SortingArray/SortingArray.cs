using System;
/* 07.Sorting an array means to arrange its elements in increasing order. 
 * Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, 
 * move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.*/


class SortingArray
{
    static void Main()
    {
        Console.Write("Enter the size of your array: ");
        int length = int.Parse(Console.ReadLine());

        int[] arr = new int[length];
 
        for (int i = 0; i < length; i++)
        {
            Console.Write("Element {0}: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }

                if (min != i)
                {
                    int swap = arr[i];
                    arr[i] = arr[min];
                    arr[min] = swap;
                }
            }
        }

        for (int i = 0; i < length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

    }
}

