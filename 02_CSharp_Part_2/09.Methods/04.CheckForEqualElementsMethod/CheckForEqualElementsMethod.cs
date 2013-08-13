using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a method that counts how many times given 
 *number appears in given array. Write a test program 
 *to check if the method is working correctly.*/

class CheckForEqualElementsMethod
{
    static int elementToFind = 5;

    static void TestCountsElement()
    {
        int[] arrTest1 = {-2, -3, -2, -2, -2}; // testing negative
        int[] arrTest2 = new int[0]; // empty test
        int[] arrTest3 = new int[10]; // zero test

        Console.WriteLine(CountsElement(arrTest1, -2)); // expected output: 4
        Console.WriteLine(CountsElement(arrTest2, 0)); // expected output: 0
        Console.WriteLine(CountsElement(arrTest3, 0)); // expected output: 10
        
    }

    static int CountsElement(int[] arr, int elementToFind)
    {
        int counter = 0;

        if (arr.Length > 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == elementToFind)
                {
                    counter++;
                }
            }
        }
        else return 0;
        return counter;
    }

    static void Main()
    {
        TestCountsElement();
        int[] arr = { 3, 5, 12, 5, 6, 8, 5, 4, 5, 3, 7 };

        int count = CountsElement(arr, elementToFind);

        Console.WriteLine("The number {0} appears {1} times in the array!", elementToFind, count);
    }
}

