using System;
using System.Linq;
/* 05.You are given an array of strings. 
 * Write a method that sorts the array 
 * by the length of its elements 
 * (the number of characters composing them).*/

class SortStringArray
{
    static void Main()
    {
        string[] array = { "tree", "shotgun", "blast", "00000000", "12" };

        // lamda expression
        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));

        // or as LINQ query expresiion:
        // var element = array.OrderBy(x => x.Length);

        foreach (var item in array)
        {
            Console.WriteLine("{0}", item);
        }
    }
}

