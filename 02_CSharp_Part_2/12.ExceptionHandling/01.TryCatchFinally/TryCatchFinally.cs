using System;
/* 01. Write a program that reads an integer number 
 * and calculates and prints its square root. 
 * If the number is invalid or negative, 
 * print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.*/


class TryCatchFinally
{
    static void Main()
    {
        Console.Write("Enter a number: ");

        try
        {
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num));
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number must be positive!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good Bye!");
        }
    }
}

