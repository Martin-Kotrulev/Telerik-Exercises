using System;

class SumNumbers
{
    static void Main()
    {
        Console.Write("Please enter a number \"n\": ");
        int n = int.Parse(Console.ReadLine());

        int sum = n;

        // on every cycle, every next number is added to sum
        for (int i = n; i > 0; i--)
        {
            Console.Write("You have {0} more number/s to enter: ", n);
            int num = int.Parse(Console.ReadLine());

            sum += num;

            Console.WriteLine(sum);
        }
        
    }
}

