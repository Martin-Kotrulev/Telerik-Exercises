using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a method that reverses the digits of given decimal number. 
 * Example: 256  652 */

class ReverseDigitsOfANumber
{
    static int n = int.Parse(Console.ReadLine());

    static string ReverseDigits(string number)
    {
        string reversed = "";
        for (int i = 0; i < number.Length; i++)
        {
            reversed += number[number.Length - i - 1];
        }
        return reversed;
    }

    static void Main()
    {
        string number = n.ToString();
        number = ReverseDigits(number);
        Console.WriteLine(number);
    }
}

