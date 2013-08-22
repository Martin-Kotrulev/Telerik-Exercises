using System;
using System.IO;
using System.Collections.Generic;
/*06. Write a program that reads a text file containing 
 *a list of strings, sorts them and saves them 
 *to another text file. Example:
	Ivan			George
	Peter	---->	Ivan
	Maria			Maria
	George			Peter*/


class NamesSorter
{
    static List<string> ReadNames()
    {
        List<string> names = new List<string>();

        using (StreamReader sr = new StreamReader("../../unsorted.txt"))
        {
            for (string name; (name = sr.ReadLine()) != null; )
            {
                names.Add(name);
            }
        }
        return names;
    }

    static void WriteNames(List<string> names)
    {
        using (StreamWriter sw = new StreamWriter("../../sorted.txt"))
        {
            foreach (string name in names)
            {
                sw.WriteLine(name);
            }
        }
    }

    static void Main()
    {
        List<string> names = ReadNames();
        names.Sort();
        WriteNames(names);
    }
}

