using System;

class CheckPointCircle
{
    static void Main()
    {
        Console.Write("Please enter the x coordinate of the point x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Please enter the y coordinate of the point y: ");
        int y = int.Parse(Console.ReadLine());

        // the formulas for the point and for the radius:
        int point = (x * x) + (y * y);
        int radius = 5 * 5;
        bool check = point <= radius;

        Console.WriteLine(
        check ? "The point is in the circle!" : "The point is not in the circle!");
    }
}
