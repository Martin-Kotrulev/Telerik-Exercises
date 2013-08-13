using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*02.Write a method GetMax() with two parameters
 *that returns the bigger of two integers.
 *Write a program that reads 3 integers from the console
 *and prints the biggest of them using the method GetMax().*/

class GetMaxMethod
{
    static int GetMax(int a, int b)
    {
        int max = a;
        if (b > a)
        {
            max = b;
        }
        return max;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int max = GetMax(GetMax(a, b), c);

        Console.WriteLine("The greatest of the three numbers is {0}!", max);
    }
}

