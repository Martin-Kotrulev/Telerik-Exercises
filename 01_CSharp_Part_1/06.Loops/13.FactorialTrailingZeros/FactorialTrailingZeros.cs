using System;
using System.Numerics;
/* 13. Write a program that calculates for given N 
  how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal 
    to the number of its prime divisors of value 5. Think why!
*/

class FactorialTrailingZeros
{
    // proving method;
    static BigInteger Factorial(int n)
    {
        BigInteger factorial = 1;

        while (n > 0)
        {
            factorial *= n;
            n--;
        }
        return factorial;
    }

    static void Main()
    {
        Console.Write("Enter \"N!\" number to calculate its trailing zeroes: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 0;
        int zeroes = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial = i;
            while (factorial % 5 == 0)
            {
                zeroes++;
                factorial /= 5; // divide factorial again, to check the product
            }                   // is again divisible of 5;                        
        }
        
        Console.WriteLine("The number {0}! has {1} trailing zeroes!", n, zeroes);
        Console.WriteLine("Just for fun, the proof itself: {0}", Factorial(n));
    }
}

