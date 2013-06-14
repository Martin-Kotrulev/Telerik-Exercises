using System;
using System.Numerics;
/*05. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).*/

class FactorialCalculation
{
    static void Main()
    {
        Console.WriteLine("Please enter \"N\" and \"K\" for N!*K!/(K - N) (1<K<N): ");

        int n = int.Parse(Console.ReadLine());
        int tmpN = n;
        int k = int.Parse(Console.ReadLine());
        int tmpK = k;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        if (n > k && k != 0)
        {
            do
            {
                factorialN *= n;
                n--;

            } while (n > 0);

            do
            {
                factorialK *= k;
                k--;
            } while (k > 0);

            BigInteger result = factorialN * factorialK;
            decimal finalResult = (decimal)result / (tmpK - tmpN);

            Console.WriteLine("{0}!*{1}!/({2}-{3})={4}", tmpN, tmpK, tmpK, tmpN, finalResult);
        }
        else
        {
            Console.WriteLine("1<K<N!!!");
        }
    }
}

