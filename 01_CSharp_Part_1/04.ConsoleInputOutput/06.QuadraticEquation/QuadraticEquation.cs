using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("In the quadratic equation ax^2 + bx + c = 0, enter value for \"a\": ");
        double a = int.Parse(Console.ReadLine());

        Console.Write("Enter value for \"b\": ");
        double b = int.Parse(Console.ReadLine());

        Console.Write("Enter value for \"c\": ");
        double c = int.Parse(Console.ReadLine());

        // the formula!
        double d = (b * b) - (4 * a * c);

        if (d < 0 || a == 0.0)
        {
            Console.WriteLine("The equation doesn't have real roots!");
        }
        else if (d > 0)
        {
            d = Math.Sqrt(d);
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);

            Console.WriteLine("The equation has two real roots: {0} and {1}", x1, x2);
        }
        else
        {
            d = Math.Sqrt(d);
            double x = (-b + d) / (2 * a);
            Console.WriteLine("The equation has one real root: {0}", x);
        }
    }
}

