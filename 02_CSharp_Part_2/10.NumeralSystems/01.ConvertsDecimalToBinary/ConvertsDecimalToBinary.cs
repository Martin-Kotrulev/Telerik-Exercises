using System;
using System.Collections.Generic;
/*01.Write a program to convert decimal numbers to their binary representation.*/


class ConvertsDecimalToBinary
{
    static void TestConvertToBinary()
    {
        ConvertToBinary(0); ConvertToBinary(1); ConvertToBinary(2);
        ConvertToBinary(4); ConvertToBinary(8); ConvertToBinary(15);
    }

    static void ConvertToBinary(int num)
    {
        List<byte> binaryRepresent = new List<byte>();

        while (num != 0)
        {
            int currentBit = (num & 1); // same as num % 2
            binaryRepresent.Add((byte)currentBit);
            num >>= 1; // same as num / 2
        }
        binaryRepresent.Reverse();
        PrintInBase2(binaryRepresent);
    }

    static void PrintInBase2(List<byte> binary)
    {
        foreach (var item in binary)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Please enter a number: ");
        int num = int.Parse(Console.ReadLine());

        ConvertToBinary(num);
        //TestConvertToBinary();
    }
}

