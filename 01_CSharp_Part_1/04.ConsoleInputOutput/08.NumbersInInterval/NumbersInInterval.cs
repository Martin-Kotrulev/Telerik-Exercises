using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("To see all the numbers between [1...n], please enter \"n\": ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("{0}", i);
        }
        Console.WriteLine();
    }
}

