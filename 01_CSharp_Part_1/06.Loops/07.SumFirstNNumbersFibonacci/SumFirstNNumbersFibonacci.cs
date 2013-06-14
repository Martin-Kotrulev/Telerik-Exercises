﻿using System;
using System.Numerics;
/*07. Write a program that reads a number N and calculates the sum
 *of the first N members of the sequence of Fibonacci:
 *0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
 *Each member of the Fibonacci sequence 
 *(except the first two) is a sum of the previous two members.*/

class SumFirstNNumbersFibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger[] fibonacci = new BigInteger[n];

        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger third = 0;
        BigInteger sum = first + second;

        fibonacci[0] = first;
        fibonacci[1] = second;

        for (int i = 2; i < fibonacci.Length; i++)
        {
            third = first + second;
            first = second;
            second = third;
            fibonacci[i] = third;
            sum += third;
        }

        for (int i = 0; i < fibonacci.Length; i++)
        {
            Console.WriteLine("+ {0}", fibonacci[i]);
        }
        Console.WriteLine("= {0}", sum);
    }
}

