using System;
using System.Text;
using System.Threading;
using System.Globalization;

class CopyrightTriangle
{
    static void Main()
    {
        //reset regional settings and using UTF-8 encoding to properly print the copyright sign;
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.UTF8;

        char cR = '\u00A9';
        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", cR);
    }
}

