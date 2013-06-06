using System;

class BitExchange
{
    static void Main()
    {
        Console.Write("Please enter a positive 32bit integer: ");
        uint n = uint.Parse(Console.ReadLine());

        Console.WriteLine( //print your number in binary representation with pading of zeroes;
            "Binary represantation of your number is: {0}",
            Convert.ToString(n, 2).PadLeft(32, '0'));

        // on every turn the for loop checks the value ot the given bit position,
        // and paste it + 21 positions, after that the given positions are altered to 0
        for (int p1 = 3; p1 < 6; p1++)
        {
            int p2 = p1 + 21;

            uint mask1 = (uint)(1 << p1);
            uint mask2 = (uint)(1 << p2);
            uint bit1 = (n & mask1);
            uint bit2 = (n & mask2);

            if (bit1 == 0)
            {
                uint replacer = (uint)(1 << p2);
                n = (n & ~replacer);
            }
            else
            {
                uint replacer = (uint)(1 << p2);
                n = (n | replacer);
            }

            if (bit2 == 0)
            {
                uint replacer = (uint)(1 << p1);
                n = (uint)(n & ~replacer);
            }
            else
            {
                uint replacer = (uint)(1 << p1);
                n = (n | replacer);
            }
        }
        Console.WriteLine(
            "After exchange on the 24, 25 and 26th bit the number is {0}." +
            "\nBinary representation : {1}",
            n, Convert.ToString(n, 2));
    }
}

