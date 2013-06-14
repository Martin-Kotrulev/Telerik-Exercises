using System;
/*04. Write a program that calculates N!/K! for given N and K (1<K<N).*/

class DivideNFactorialKFactorial
{

    static void Main()
    {
        Console.WriteLine("Please enter \"N\" and \"K\" for N!/K! (1<K<N): ");

        int n = int.Parse(Console.ReadLine());
        int nTmp = n;
        int k = int.Parse(Console.ReadLine());
        int kTmp = k;
        decimal factorial = 1;

        if (n > k && k != 0)
        {
            // when divide two factorials
            // N!/K! = (K + 1)*(K + 2)...N;
            // 6! / 3! = 6 * 5 * 4 = 120;
            while (n > k)
            {
                factorial *= n;
                n--;
            }
            Console.WriteLine("{0}! / {1} = {2}", nTmp, kTmp, factorial);
        }
        else
        {
            Console.WriteLine("1<K<N!!!");
        }
    }
}

