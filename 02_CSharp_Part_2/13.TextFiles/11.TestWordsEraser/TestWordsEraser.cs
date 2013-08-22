using System;
using System.IO;
using System.Text.RegularExpressions;
/* 11. Write a program that deletes from a text 
 * file all words that start with the prefix "test". 
 * Words contain only the symbols 0...9, a...z, A…Z, _.*/

class TestWordsEraser
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("../../someText.txt"))
        using (StreamWriter sw = new StreamWriter("../../someText.txt"))
        {
            for (string line; (line = sr.ReadLine()) != null; )
            {
                sw.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
            }
        }
    }
}

