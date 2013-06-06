using System;

class BitPosBool
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int x = int.Parse(Console.ReadLine());

        // creates mask which goes to the third bit checking with & operator:
        int p = 3;
        int mask = 1 << p;
        int xAndMask = x & mask;
        int bit = xAndMask >> p;
            
        Console.WriteLine(xAndMask == 0 ? "The third bit is 0!" : "The third bit is 1!");
    }
}
