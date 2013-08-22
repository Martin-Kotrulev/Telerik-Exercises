using System;
using System.IO;
/* 02. Write a program that concatenates 
 * two text files into another text file.*/


class TwoFilesConcatenator
{
    static void WriteToFile(StreamWriter outputWriter, string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            for (string line; (line = sr.ReadLine()) != null; )
            {
                outputWriter.WriteLine(line);
            }
        }
    }

    static void Main()
    {
        string[] filesPath = { "../../TwoFilesConcatenator.cs", 
                                 "../../TwoFilesConcatenator.cs" };

        using (StreamWriter ouputWriter = new StreamWriter("../../output.txt"))
        {
            foreach (string path in filesPath)
            {
                WriteToFile(ouputWriter, path);
            }
        }
    }
}

