using System;
using System.IO;
using System.Collections.Generic;
/* 09. Write a program that deletes from given 
 * text file all odd lines. The result should be in the same file.*/

class OddLinesEraser
{
    static List<string> CheckEvenLines()
    {
        List<string> evenLines = new List<string>();
        int row = 1;

        using (StreamReader sr = new StreamReader("../../someFile.txt"))
        {
            for (string line; (line = sr.ReadLine()) != null; row++)
            {
                if ((row & 1) == 0)
                {
                    evenLines.Add(line);
                }
            }
        }
        return evenLines;
    }

    static void WriteEvenLines(List<string> evenLines)
    {
        // Clears the file and then writes
        using (StreamWriter sw = new StreamWriter("../../someFile.txt")) 
        {
            foreach (string line in evenLines)
            {
                sw.WriteLine(line);
            }
        }
    }

    static void Main()
    {
        WriteEvenLines(CheckEvenLines());
    }
}

