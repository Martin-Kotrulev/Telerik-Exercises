using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*03.Write a program to convert decimal numbers to their hexadecimal representation.*/

class DecToHexConverter
{
    static void DecToHex(int num)
    {
        string hex = "";
        while (num != 0)
        {
            int carry = (num & 15); // same as num % 16
            if (carry < 10) hex += carry;
            else
            {
                switch (carry)
                {
                    case 10: hex += 'A'; break;
                    case 11: hex += 'B'; break;
                    case 12: hex += 'C'; break;
                    case 13: hex += 'D'; break;
                    case 14: hex += 'E'; break;
                    case 15: hex += 'F'; break;
                    default: break;
                }
            }
            num >>= 4; // same as num / 16;
        }
        Print(hex);
    }

    static void Print(string toPrint)
    {
        for (int i = toPrint.Length - 1; i >= 0; i--)
        {
            Console.Write(toPrint[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        DecToHex(num);
    }
}

