using System;
/** Write a program that reads an array of integers
 * and removes from it a minimal number of elements
 * in such way that the remaining array is sorted
 * in increasing order. Print the remaining sorted array. Example:
	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}*/

class RemoveToSort
{
    static void Check(int[] arr, int[] indexes, int k)
    {
        // cheching if the current combination is the longest
        for (int i = 0; i < k; i++)
        {
            if (arr[indexes[i]] > arr[indexes[i + 1]]) return;
        }

        // printing the combination 
        for (int i = 0; i <= k; i++)
        {
            Console.Write(arr[indexes[i]] + (i == k ? "\n" : " "));
        }

        Environment.Exit(0);
    }

    static void Combination(int[] arr, int[] indexes, int k, int i, int next)
    {
        if (i > k) return; // bottom of the recursion 

        for (int j = next; j < arr.Length; j++)
        {
            indexes[i] = j;

            if (i == k)
            {
                Check(arr, indexes, k);
            }
            // recursively calling Combination() with iteration on i and j
            Combination(arr, indexes, k, i + 1, j + 1);
        }
    }

    static void Main()
    {
        int[] arr = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // creating array of indexes for each element in arr
        int[] indexes = new int[arr.Length];
        // building combinations from the last element
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Combination(arr, indexes, i, 0, 0); // "k" integer in 
            // the method Combination() is the current index
        }
    }
}

