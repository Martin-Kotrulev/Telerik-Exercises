using System;
/*06. Write a program that, for a given two integer numbers N and X,
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN.*/

class CalculatesSumGivenXandN
{
    static void Main()
    {
        Console.WriteLine("Please enter \"N\" and \"X\":");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal s = 1;
        decimal factorial = 1;

        for (int i = 0; i < n; i++)
        {
            int j = i + 1;
            factorial = 1; // every cicle factorial becomes 1;

            // factorial calculation:
            while (j > 0)
            {
                factorial *= j;
                j--;
            }

            // final calculation (on every cicle X^2,3,4... by bitwise operation) 
            s += factorial / (x << i);
        }
        Console.WriteLine("1 + 1!/X + 2!/X2 + … + N!/XN = {0}", s);
    }
}

