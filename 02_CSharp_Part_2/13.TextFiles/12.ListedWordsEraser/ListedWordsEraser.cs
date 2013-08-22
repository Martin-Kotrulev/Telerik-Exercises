using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;
/*12. Write a program that removes from a text file all 
 * words listed in given another text file. 
 * Handle all possible exceptions in your methods.*/

class ListedWordsEraser
{
    static void Main()
    {
       try
        {
            string[] words = File.ReadAllLines("../../words.txt");

            using (StreamReader sr = new StreamReader("../../test.txt"))
            using (StreamWriter sw = new StreamWriter("../../result.txt"))
            {
                for (string line; (line = sr.ReadLine()) != null; )
                {
                    // Delete listed words
                    foreach (string  word in words)
                    {
                        line = Regex.Replace(line, word, String.Empty);
                    }
                    sw.WriteLine(line);
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

