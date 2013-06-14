using System;
/*10. Write a program to calculate the Nth Catalan number by given N.*/

class NthCatalanNumber
{
    static decimal CalculateFactorial(decimal x)
    {
        decimal factorial = 1;

        do
        {
            factorial *= x;
            x--;
        } while (x > 0);

        return factorial;
    }
    static void Main()
    {
        Console.Write("Enter \"N\" to see the Nth Catalanian number: ");
        decimal n = int.Parse(Console.ReadLine());
        decimal result = CalculateFactorial(2 * n) / (CalculateFactorial(n + 1) * CalculateFactorial(n));

        Console.WriteLine(result);
    }
}

