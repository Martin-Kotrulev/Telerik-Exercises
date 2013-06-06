using System;

class RectangleAndCircle
{
    static void Main()
    {
        Console.WriteLine(
            "To find if your point is in a given circle and rectangle simultaneously:");
        Console.Write("Please enter the x coordinate of the point x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Please enter the y coordinate of the point y: ");
        int y = int.Parse(Console.ReadLine());

        int radius = 3;
        bool circleResult = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= (radius * radius);
        bool rectangleResult = ((x > -1) && (x < -3)) && ((y < 1) && (y > 7));
        
        Console.WriteLine(
            circleResult ? "The point is in the circle!" : "The point is not in the circle!" );
        Console.WriteLine(
            rectangleResult ? "But it's not in the rectangle!" : "The point is in the rectangle!");

    }
}
