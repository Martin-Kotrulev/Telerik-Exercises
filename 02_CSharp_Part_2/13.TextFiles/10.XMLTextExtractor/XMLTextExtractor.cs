using System;
using System.IO;
/* 10. Write a program that extracts from given 
 * XML file all the text without the tags.*/

class XMLTextExtractor
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("../../someXML.txt"))
        {
            // Reading char by char and saving the char value in int
            for (int i; (i = sr.Read()) != -1; )
            {
                // Finding text only between '>' and '<'
                if (i == '>')
                {
                    string text = string.Empty;

                    while ((i = sr.Read()) != -1 && i != '<')
                    {
                        text += (char)i;
                    }

                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        Console.WriteLine(text.Trim()); 
                    }
                }
            }
        }
    }
}

