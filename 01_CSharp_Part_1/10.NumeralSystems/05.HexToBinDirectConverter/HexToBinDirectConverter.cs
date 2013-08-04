using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*05.Write a program to convert hexadecimal numbers to binary numbers (directly).*/

class HexToBinDirectConverter
{
    static int ReturnCharValue(char n)
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

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            int current = ReturnCharValue(input[i]);
            result += Convert.ToString(current, 2);
        }
        Console.WriteLine(result);
    }
}
