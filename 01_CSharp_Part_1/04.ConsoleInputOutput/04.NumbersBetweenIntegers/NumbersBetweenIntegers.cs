using System;

class NumbersBetweenIntegers
{
    static void Main()
    {
        Console.Write("Please enter the first positive integer: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Please enter the second positive integer: ");
        int secondNum = int.Parse(Console.ReadLine());

        int count = 0;
        
        for (int i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine("Between {0} and {1} there are {2}", firstNum, secondNum, count);
    }
}

