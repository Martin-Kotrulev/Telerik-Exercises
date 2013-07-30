using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.12.Write a method that adds two polynomials. 
 * Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5  |5|0|1|
 Extend the program to support also subtraction and multiplication of polynomials.*/
// USING DIFFERENT APPROACH FOR EXERCISE

class Polynomials
{
    static void PrintPolynomial(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.Write(arr[i] + "*x^" + i + (i == 0 ? "\n" : " + "));
        }
    }

    static int[] Add(int[] a, int[] b)
    {
        if (a.Length > b.Length)
        {
            return Add(b, a); // a <= b
        }

        PrintPolynomial(a);
        PrintPolynomial(b);

        int[] result = new int[b.Length];

        int i = 0;

        for (; i < a.Length; i++)
        {
            result[i] = a[i] + b[i];
        }

        // If the second array has digits left
        for (; i < b.Length; i++)
        {
            result[i] = b[i]; 
        }

        return result;
    }

    static int[] Subtract(int[] a, int[] b, bool reversed = false)
    {
        if (a.Length > b.Length)
        {
            // a must be <= b
            return Subtract(b, a, reversed: true); 
        }

        PrintPolynomial(a);
        PrintPolynomial(b);

        int[] result = new int[b.Length];

        int i = 0;

        for (; i < a.Length; i++)
        {
            // For each digit in both arrays
            result[i] = (reversed ? b[i] - a[i] : a[i] - b[i]); 
        }

        for (; i < b.Length; i++)
        {
            // If the second array has digits left
            result[i] = (reversed ? b[i] : -b[i]); 
        }

        return result;
    }

    public static int[] Multiply(int[] a, int[] b)
    {
        PrintPolynomial(a);
        PrintPolynomial(b);

        // Array for multiply each by each
        int[] result = new int[a.Length + b.Length - 1];

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                result[i + j] += a[i] * b[j];
            }
        }

        return result;
    }

    static void Main()
    {
        PrintPolynomial(Add(new int[] { 2, 0, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6 }));
        Console.WriteLine();

        PrintPolynomial(Subtract(new int[] { 2, 0, 3, 4 }, new int[] { 1, 2, 3, 4, 5, 6 }));
        Console.WriteLine();

        PrintPolynomial(Subtract(new int[] { 1, 2 }, new int[] { 1 }));
        Console.WriteLine();

        PrintPolynomial(Multiply(new int[] { 2, 1 }, new int[] { 1, 1 }));
        Console.WriteLine();
    }
}

