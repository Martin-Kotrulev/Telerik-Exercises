using System;

    class ValueOnPos
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please enter the bit position: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter value for the position (0 or 1): ");
            int v = int.Parse(Console.ReadLine());

            if (v == 1) // if hte bit on the entered position is 1, the bit is altered to 0;
            {
                int mask = 1 << p;
                int nOrMask = n | mask;
                Console.WriteLine(nOrMask);
            }
            else if (v == 0) // if it is 0, the bit is altered to 1;
            {
                int mask = ~(1 << p);
                int nAndMask = n & mask;
                Console.WriteLine(nAndMask);
            }
            else 
            {
                Console.WriteLine("Sorry, you've entered invalid value for the bit!!!");
            }
        }
    }
