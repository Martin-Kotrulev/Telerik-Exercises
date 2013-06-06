using System;


class AreaRectangle
{
    static void Main()
    {
        Console.Write("Please enter the height of the rectangle: ");
        int rectangleHeight = int.Parse(Console.ReadLine());

        Console.Write("Now enter the width of the rectangle: ");
        int rectangleWidth = int.Parse(Console.ReadLine());

        // rectangle area furmula:
        int rectangleArea = rectangleHeight * rectangleWidth;

        Console.WriteLine("The area of the rectangle is: {0}", rectangleArea);
    }
}