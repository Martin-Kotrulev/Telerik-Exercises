using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxMinAvgSumProduct
{
    static int FindMax(params int[] arr)
    {
        int length = arr.Length > 0 ? arr.Length : 0;
        int max = arr[0];

        if (length > 0)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
        }
        else return length;
        return max;
    }

    static int FindMin(params int[] arr)
    {
        int length = arr.Length > 0 ? arr.Length : 0;
        int min = arr[0];
        if (length > 0)
        {
            for (int i = 1; i < length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
        }
        else return length;
        return min;
    }

    static decimal FindAvg(params int[] arr)
    {
        decimal average = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            average += arr[i];
        }
        average /= arr.Length;
        return average;
    }

    static int FindSum(params int[] arr)
    {
        int sum = 0;
        foreach (var number in arr)
        {
            sum += number;
        }
        return sum;
    }

    static int FindProduct(params int[] arr)
    {
        int product = 1;
        foreach (var number in arr)
        {
            product *= number;
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine("Min = {0}", FindMin(5, 1, 4, 3));
        Console.WriteLine("Max = {0}", FindMax(3, 6 , 4, 2, 1, 5, 7));
        Console.WriteLine("Avg = {0}", FindAvg(16, 8 , -4, 3));
        Console.WriteLine("Sum = {0}", FindSum(6, 2, -3));
        Console.WriteLine("Product = {0}", FindProduct(1, 2, 3, 4));
        Console.WriteLine();
    }
}
