using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*06.Write a program to convert binary numbers to hexadecimal numbers (directly).*/

class BinToHexDirectConverter
{
    static string BinToDec(string input)
    {
        int result = 0;
        string hex = "";
        for (int i = 0; i < input.Length; i++)
        {
            byte current = byte.Parse(input[i].ToString());
            if (i == input.Length - 2) result += current * 2; // 2^1 = 2
            else if (i == input.Length - 1) result += current * 1; // 2^0 = 1
            else result += (current << 1) << (input.Length - i - 2);
        }
        if (result <= 9) return result.ToString();
        else
        {
            switch (result)
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
        return hex;
    }

    static string ReverseString(string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--) // Reverse the string input
        {
            reversed += str[i];
        }
        return reversed;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = "";

        for (int i = input.Length - 1; i >= 0; i -= 4)
        {
            string current = "";
            for (int j = i; j > i - 4 && j >= 0; j--)
            {
                current += input[j];
            }
            current = ReverseString(current);
            if (current.Length != 4) current = Convert.ToString(current).PadLeft(4, '0');
            result += BinToDec(current);
        }

        result = ReverseString(result);
        Console.WriteLine(result);
    }
}

