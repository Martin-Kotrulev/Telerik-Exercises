using System;
using System.IO;
/* 03. Write a program that reads a text file and inserts 
 * line numbers in front of each of its lines. 
 * The result should be written to another text file.*/

class InsertRowsNumberInAFile
{
    static void Main()
    {
        int row = 1;

        using (StreamReader fileReader = 
            new StreamReader("../../InsertRowsNumberInAFile.cs"))
        using (StreamWriter outputWriter = new StreamWriter("../../output.txt"))
        {
            for (string line; (line = fileReader.ReadLine()) != null; row++)
            {
                outputWriter.WriteLine("{0}. {1}", row, line);
            }
        }
    }
}

