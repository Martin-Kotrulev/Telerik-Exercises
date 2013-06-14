using System;
/*08. Write a program that calculates the greatest common divisor (GCD)
 *of given two numbers. Use the Euclidean algorithm (find it in Internet).*/

class GCDOfGiven2Integers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int r = 1;

        if (a > b)
        {
            while (r > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("Greatest common divisor: {0}", a);
        }
        else
        {
            while (r > 0)
            {
                r = b % a;
                b = a;
                a = r;
            }
            Console.WriteLine("Greatest common divisor: {0}", b);
        }
    }
}

