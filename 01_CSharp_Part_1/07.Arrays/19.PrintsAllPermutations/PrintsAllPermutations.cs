using System;
/* Write a program that reads a number
 * N and generates and prints all the 
 * permutations of the numbers [1 … N]. Example:
	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3},
 * {2, 3, 1}, {3, 1, 2}, {3, 2, 1}*/

class PrintsAllPermutations
{
    static void Check(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            // printing the permutations based on the index + 1;
            Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "\n" : " "));
        }
    }

    static void Permutation(int[] arr, bool[] used, int i)
    {
        // at the bottom of the recursion the
        // elements in the array are checked and printed;
        if (i == arr.Length)
        {
            Check(arr);
            return;
        }

        for (int j = 0; j < arr.Length; j++)
        {
            // if current permutation is already used
            // proceed on the next permutation;
            if (used[j])
            {
                continue;
            }

            arr[i] = j;

            used[j] = true;
            // recursively calling Permutation()
            Permutation(arr, used, i + 1);
            used[j] = false;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Enter value for N to see all permutations of the numbers[1...N]: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        // boolean array for the used permutations
        bool[] used = new bool[arr.Length];

        Permutation(arr, used, 0);
    }
}

