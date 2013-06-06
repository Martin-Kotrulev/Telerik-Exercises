using System;

class StringNumbers
{
    static void Main()
    {
        string sequence = "2, -3, 4, -5, 6, -7,";
        Console.WriteLine("If your sequence of numbers is: {0}\n", sequence);
        Console.WriteLine("The first 10 are: ");

        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(" -{0}, ", i);
            }
            else
            {
                Console.Write("{0},", i);
            }
        }
        Console.WriteLine();
    }
}
