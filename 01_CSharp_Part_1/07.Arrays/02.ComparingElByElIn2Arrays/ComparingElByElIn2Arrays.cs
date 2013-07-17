using System;
/* 02.Write a program that reads two arrays from the 
 * console and compares them element by element.*/

class ComparingElByElIn2Arrays
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the two arrays: ");
        int firstArrLength = int.Parse(Console.ReadLine());
        int secondArrLength = int.Parse(Console.ReadLine());

        int[] firstArray = new int[firstArrLength];
        int[] secondArray = new int[secondArrLength];
        bool equal = true;

        for (int i = 0; i < firstArrLength; i++)
        {
            Console.Write("Element {0} of the first array: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArrLength; i++)
        {
            Console.Write("Element {0} of the second array: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        if (firstArrLength != secondArrLength)
        {
            equal = false;
        }
        else
        {
            int length = firstArrLength;

            for (int i = 0; i < length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false; 
                    break;
                }
            }
        }
        Console.WriteLine("The two arrays are equal? - {0}", equal);
    }
}

