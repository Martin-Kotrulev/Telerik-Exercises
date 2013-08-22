using System;
using System.IO;
/* 07. Write a program that replaces all occurrences 
 * of the substring "start" with the substring "finish" 
 * in a text file. Ensure it will work with large files (e.g. 100 MB).*/

class SubstringTextReplacer
{
    static void Main()
    {
        using (StreamReader textReader = new StreamReader("../../SomeText.txt"))
        using (StreamWriter replacer = new StreamWriter("../../output.txt"))
        {
            for (string line; (line = textReader.ReadLine()) != null; )
            {
                replacer.WriteLine(line.Replace("start", "finish")); // Works with capitals too
                //replacer.WriteLine(line.Replace("finish", "start")); // Reversed
            }
        }
    }
}

