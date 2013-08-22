using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;
/* 13. Write a program that reads a list of 
 * words from a file words.txt and finds 
 * how many times each of the words is 
 * contained in another file test.txt. 
 * The result should be written in the file result.txt 
 * and the words should be sorted by the number of their 
 * occurrences in descending order. 
 * Handle all possible exceptions in your methods.*/

class ListedWordsCounter
{
    static void Main()
    {
        try
        {
            // Save the words from the file in a string array
            string[] words = File.ReadAllLines("../../words.txt");
            int[] occurrances = new int[words.Length];

            // Count words occurrances
            using (StreamReader sr = new StreamReader("../../test.txt"))
            {
                for (string line; (line = sr.ReadLine()) != null; )
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        // Checks every line for matches
                        occurrances[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                    }
                }
            }

            // Sort like a dictionary
            Array.Sort(occurrances, words);

            // Write result
            using (StreamWriter output = new StreamWriter("../../result.txt"))
            {
                for (int i = words.Length - 1; i >= 0; i--) // In descending order
                {
                    output.WriteLine("{0}: {1}", words[i], occurrances[i]);
                }
            }
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (SecurityException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

