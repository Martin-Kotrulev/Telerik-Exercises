using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*04.Write a program to convert hexadecimal numbers to their decimal representation.*/

class HexToDec
{

    static int getChar(char n)
    {
        int result = 0;
        if (n <= '9') return int.Parse(n.ToString());
        switch (n)
        {
            case 'A': return 10;
            case 'B': return 11;
            case 'C': return 12;
            case 'D': return 13;
            case 'E': return 14;
            case 'F': return 15;
            default: break;
        }
        return result;
    }

    static long HexConverter(string input)
    {
        long sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int current = getChar(input[input.Length - i - 1]);
            sum += current * (int)Math.Pow(16, i);
        }
        return sum;
    }

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        long result = HexConverter(input);
        Console.WriteLine(result);
    }
}
