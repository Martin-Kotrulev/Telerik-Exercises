using System;
/* 12. Write a program that creates an array containing 
 * all letters from the alphabet (A-Z). 
 * Read a word from the console and print
 * the index of each of its letters in the array.*/

class IndexesOfEachCharInWord
{
    static void Main()
    {
        string input = Console.ReadLine();

        // crating an array with the indexes of the small letters
        // and for the capital letters;
        int[] alphaIndex = new int[53];

        for (int i = 0; i < alphaIndex.Length / 2; i++)
        {
            alphaIndex[i] = 'a' + i; 
        }

        for (int i = alphaIndex.Length / 2, k = 0; i < alphaIndex.Length; i++, k++)
        {
            alphaIndex[i] = 'A' + k;
        }

        // if the index in the word matches index in the array
        // the letter and the index are printed on the console;
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < alphaIndex.Length; j++)
            {
                if (input[i] == alphaIndex[j])
                {
                    Console.WriteLine("Leter {0} has index: {1}", input[i], j);
                    break;
                }
            }
        }
    }
}

