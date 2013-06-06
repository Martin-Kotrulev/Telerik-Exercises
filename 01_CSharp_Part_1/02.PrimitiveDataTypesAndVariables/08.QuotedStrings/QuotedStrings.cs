using System;

class QuotedStrings
{
    static void Main()
    {
        string quoted = "The \"use\" of quotations causes difficulties.";
        string unquoted = "The use of quotations causes difficulties.";
        Console.WriteLine("{0}\n{1}", quoted, unquoted);
    }
}

