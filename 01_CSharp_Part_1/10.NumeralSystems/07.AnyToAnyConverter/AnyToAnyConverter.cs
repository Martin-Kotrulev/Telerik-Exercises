using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*07.Write a program to convert from any numeral system of 
 * given base s to any other numeral system of base d (2 ≤ s, d ≤  16).*/

class AnyToAnyConverter
{
    static char GetChar(int i)
    {
        if (i >= 10) return (char)('A' + i - 10);
        else return (char)('0' + i);
    }

    static int GetNumber(string s, int i)
    {
        if (s[i] >= 'A') return s[i] - 'A' + 10;
        else return s[i] - '0';
    }

    static string Base10ToBaseX(int d, int x)
    {
        string h = String.Empty;

        for (; d != 0; d /= x)
        {
            h = GetChar(d % x) + h;
        }

        return h;
    }

    static int BaseXToBase10(string h, int x)
    {
        int d = 0;

        for (int i = h.Length - 1, p = 1; i >= 0; i--, p *= x)
            d += GetNumber(h, i) * p;

        return d;
    }

    static string BaseXToBaseY(string n, int x, int y)
    {
        return Base10ToBaseX(BaseXToBase10(n, x), y);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        string n = Console.ReadLine();

        Console.Write("Enter value for x(base): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter value for y(base to convert): ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine(BaseXToBaseY(n, x, y));
    }
}
