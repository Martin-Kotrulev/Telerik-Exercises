﻿using System;
/*01. Write a program that prints all the numbers from 1 to N.*/

class PrintNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0}, ", i);
        }
    }
}

