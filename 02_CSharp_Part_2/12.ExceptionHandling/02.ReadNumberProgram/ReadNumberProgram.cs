using System;
/* 02. Write a method ReadNumber(int start, int end) that enters 
 * an integer number in given range [start…end]. If an invalid 
 * number or non-number text is entered, the method should 
 * throw an exception. Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100*/


class ReadNumberProgram
{
    static void ReadNumber(int start, int end)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            if (!(n > start && n < end))
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("The number must be in the interval {0}-{1}", start, end);
        }
    }

    static void Main()
    {
        int start = 1;
        int end = 100;

        for (int i = 0; i < 10; i++)
        {
            ReadNumber(start, end);
        }
    }
}

