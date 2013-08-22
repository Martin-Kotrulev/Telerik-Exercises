using System;
using System.IO;
/* 01. Write a program that reads a text 
 * file and prints on the console its odd lines.*/


class OddLinesPrinter
{
    static void Main(string[] args)
    {
        // Printing the current code
        using (StreamReader sr = new StreamReader("../../OddLinesPrinter.cs"))
        {
            int row = 0;

            string line = string.Empty;
            while (line != null)
            {
                line = sr.ReadLine();
                if ((row & 1) == 0) Console.WriteLine(line);
                row++;
            }
        }
    }
}

