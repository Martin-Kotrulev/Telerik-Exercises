using System;

class ValueOfBitPos
{
    static void Main()
    {
        Console.Write("Please enter the number: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Specify which bit to be extracted: ");
        int p = int.Parse(Console.ReadLine());

        // creates mask which goes to the entered bit position, checks the value and extract it:
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine("The extracted bit has the value of: {0}", bit);
    }
}
