using System;
using System.Threading;
using System.Globalization;

class CalculateCircleAreaAndPerimeter
{
    static void Main()
    {
        begin:

        // ensure the proper use of decimal separator when using double int. for input;
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

        Console.Write("Please enter the radius \"r\" of the circle: ");
        string input = Console.ReadLine();
        double radius;
        double PI = Math.PI;

        // check if the input is a valid double integer and different from zero;
        if (double.TryParse(input, out radius) && radius != 0)
        {
            Console.WriteLine(
                "The area of the circle is: {0}\nThe perimeter of the circle is: {1}", 
                PI * (radius * radius), 2 * (PI * radius));
        }
        else
        {
            // if radius is not a valid double integer,
            // or has the value of 0, goes from the begining;
            Console.WriteLine("Invalid input or zero radius! Try again!");
            goto begin;
        }
    }
}

