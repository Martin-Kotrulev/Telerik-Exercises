using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*03.Write a method that returns the last digit of 
 *given integer as an English word. 
 *Examples: 512  "two", 1024  "four", 12309  "nine".*/

class LastDigitNameMethod
{
    static string LastDigitName(int n)
    {
        string name = "";
        n %= 10;

        switch (n)
        {
            case 0: name = "Zero"; break;
            case 1: name = "One"; break;
            case 2: name = "Two"; break;
            case 3: name = "Three"; break;
            case 4: name = "Four"; break;
            case 5: name = "Five"; break;
            case 6: name = "Six"; break;
            case 7: name = "Seven"; break;
            case 8: name = "Eight"; break;
            case 9: name = "Nine"; break;
            default:
                break;
        }
        return name;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string name = LastDigitName(n);

        Console.WriteLine("The name of the last digit in your number is {0}!", name);
    }
}

