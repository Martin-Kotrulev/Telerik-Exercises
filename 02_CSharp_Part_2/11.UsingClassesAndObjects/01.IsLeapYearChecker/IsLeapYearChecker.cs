using System;
/* 01. Write a program that reads a year from the 
 * console and checks whether it is a leap. Use DateTime.*/

class IsLeapYearChecker
{
    static void Main()
    {
        int year = 0;

        try
        {
            year = int.Parse(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Invalid year! The year must be a number!");
        }

        try
        {
            Console.WriteLine(DateTime.IsLeapYear(year) 
                ? "The year is leap!" : "The year is not leap!");
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.WriteLine("The year must be in the interval - 1...9999!");
        }
    }
}

