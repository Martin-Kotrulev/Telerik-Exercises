using System;
/*02.Write a program to convert binary numbers to their decimal representation.*/

class BinaryToDecimalConvertor
{
    static void TestConvertToDecimal()
    {
        ConvertToDecimal("0"); ConvertToDecimal("1"); ConvertToDecimal("10");
        ConvertToDecimal("11"); ConvertToDecimal("100"); ConvertToDecimal("1111");
    }

    static void ConvertToDecimal(string input)
    {
        
        int result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            // Exercise the nature of the << operator for power of two
            byte current = byte.Parse(input[i].ToString());
            if (i == input.Length - 2) result += current * 2; // 2^1 = 2
            else if (i == input.Length - 1) result += current * 1; // 2^0 = 1
            else result += (current << 1) << (input.Length - i - 2); 
        }
        Console.WriteLine(result);
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        string binInput = Console.ReadLine();
        ConvertToDecimal(binInput);
        //TestConvertToDecimal();
    }
}
