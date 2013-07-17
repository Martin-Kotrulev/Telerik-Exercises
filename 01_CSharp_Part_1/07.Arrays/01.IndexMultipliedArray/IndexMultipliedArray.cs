using System;
/* 01.Write a program that allocates array of 20 integers
 * and initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console. */


class IndexMultipliedArray
{
    static void Main()
    {
        int[] intArray = new int[20];
        int length = intArray.Length;

        for (int i = 0; i < length; i++)
        {
            intArray[i] = i * 5;
            Console.WriteLine(intArray[i]);
        }
    }
}

