using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());

        // using bitwise operation;
        if ((num & 1) == 1)
        {
            Console.WriteLine("The number is odd!");
        }
        else
        {
            Console.WriteLine("The number is even!");
        }

    }
}