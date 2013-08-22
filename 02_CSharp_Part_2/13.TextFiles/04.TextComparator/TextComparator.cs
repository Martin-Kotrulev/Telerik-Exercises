using System;
using System.IO;
/* 04. Write a program that compares two text files 
 * line by line and prints the number of lines 
 * that are the same and the number of lines 
 * that are different. Assume the files have equal number of lines.*/


class TextComparator
{
    static void Main()
    {
        int equal = 0;
        int different = 0;

        using (StreamReader firstReader = new StreamReader("../../firstFile.txt"))
        using (StreamReader secondReader = new StreamReader("../../secondFile.txt"))
        {
            for (string line1, line2; (line1 = firstReader.ReadLine()) != null &&
                (line2 = secondReader.ReadLine()) != null; )
            {
                if (line1 == line2) equal++;
                else different++;
            }
        }
        Console.WriteLine("Equal lines: {0}; Different lines:{1}", equal, different);
    }
}

