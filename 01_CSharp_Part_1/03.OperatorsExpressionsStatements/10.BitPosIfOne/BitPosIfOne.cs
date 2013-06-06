using System;

class BitPosIfOne
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a number: " );
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please specify which bit must be checked if it equals 1: ");
        int p = int.Parse(Console.ReadLine());

        // creates mask wich goes to the entered bit position and checks if it's 1:
        int mask = 1 << p;
        int nAndMask = (n & mask);
        int bit = nAndMask >> p;
        bool check = bit == 1;
        Console.WriteLine(check);
    }
}