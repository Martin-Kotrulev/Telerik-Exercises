using System;
using System.IO;
using System.Text.RegularExpressions;
/* 08. Modify the solution of the previous problem 
 * to replace only whole words (not substrings).*/

class WordReplacer
{
    static void Main()
    {
        using (StreamReader textReader = new StreamReader("../../SomeText.txt"))
        using (StreamWriter replacer = new StreamWriter("../../output.txt"))
        {
            for (string line; (line = textReader.ReadLine()) != null; )
            {
                // This regular expression doesn't change the word if there's a capitals inside
                replacer.WriteLine(Regex.Replace(line, "\\bstart\\b", "finish")); 
            }
        }
    }
}

