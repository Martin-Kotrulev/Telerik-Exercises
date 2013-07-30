using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/*10.Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a 
 * number represented as array of digits by given integer number.*/ 

class First100Factorial
{
    static BigInteger CalculateFactorial(BigInteger num)
    {
        BigInteger r = 1;
        for (int i = 2; i <= num; i++)
        {
            r *= i;
        }
        return r;
    }

    static void Main(string[] args)
    {
        BigInteger[] factArr = new BigInteger[101];
        factArr[0] = 1;
        Console.WriteLine("{0}! = {1}", 0, factArr[0]);

        for (int i = 1; i < factArr.Length; i++)
        {
            BigInteger num = i;
            factArr[i] = CalculateFactorial(i);
            Console.WriteLine("{0}! = {1}", i, factArr[i]);
        }
    }
}

