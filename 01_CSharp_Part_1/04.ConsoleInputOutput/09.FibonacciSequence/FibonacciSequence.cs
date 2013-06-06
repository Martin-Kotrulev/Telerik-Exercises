using System;
using System.Numerics;

class FibonacSequence  
{
    static void Main()
    {
        // using System.Numerics to prevent out of range;
        BigInteger firstNum = 0;
        BigInteger secondNum = 1;
        BigInteger sum = firstNum + secondNum;

        int counter = 1;
        Console.WriteLine("{0}. {1}", counter, firstNum);

        while (counter < 100)
        {
            sum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = sum;
            counter++;

            Console.WriteLine("{0}. {1}", counter, firstNum);
        }
    }
}

