using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
/* 08.Write a method that adds two positive integer
 * numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; 
 * the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.*/

class SumOfRealNumbers
{
    static string a = Console.ReadLine();
    static string b = Console.ReadLine();

    static List<int> SumArrays(int[] first, int[] second)
    {
        List<int> result = new List<int>(first.Length);

        int carry = 0;
        for (int i = 0; i < first.Length; i++)
        {
            int currentDigit = first[i] + second[i] + carry;

            // Example: 8 + 8 = 16; 16 / 10 = 1 --> the carry
            carry = currentDigit / 10;
            // 16 % 10 = 6 --> the added number to the list
            result.Add(currentDigit % 10);
        }
        if (carry == 1)
        {
            result.Add(carry);
        }

        return result;
    }

    static void FillArray(int[] array, string number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            // parsing each digit and adding it in reversed order
            array[i] = int.Parse(number[array.Length - i - 1].ToString());
        }
    }

    static void Main()
    {
        int length = a.Length;

        // Adding additional padding if lengths are different
        if (a.Length > b.Length) b = b.PadLeft(length, '0');
        if (b.Length > a.Length)
        {
            length = b.Length;
            a = a.PadLeft(length, '0');
        }

        // Filling the arrays
        int[] first = new int[length];
        FillArray(first, a);
        int[] second = new int[length];
        FillArray(second, b);

        var result = SumArrays(first, second);

        // Properly printing the result in reverse order
        for (int i = result.Count - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}

