using System;
using System.Numerics;
/* 09. In the combinatorial mathematics, the Catalan
 * numbers are calculated by the following formula:
 * Cn = (2 * n)! / (n + 1)! * n! */

class CatalanNumbers
{
    static BigInteger CalcFact(BigInteger x)
    {
        BigInteger factorial = 1;

        do
        {
            factorial *= x;
            x--;
        } while (x > 0);

        return factorial;
    }
    static void Main()
    {
        Console.Write("Enter how many Catalanian numbers you want to see: ");
        BigInteger n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            BigInteger result = CalcFact(2 * i) / (CalcFact(i + 1) * CalcFact(i));
            
            Console.WriteLine(result);
        }
        
    }
}

