using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("In the quadratic equation ax^2 + bx + c = 0, enter the values for a, b and c: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);
            
        if (d < 0 || a == 0)
        {
            Console.WriteLine("The equation has no real roots!");
        }
        else if (d == 0)
        {
            d = Math.Sqrt(d);
            double x1 = -b / (2 * a);
            Console.WriteLine("The equation has only one real root: {0}", x1);
        }
        else if (d > 0)
        {
            d = Math.Sqrt(d);
            double x1 = (-b + d) / (2 * a);
            double x2 = (-b - d) / (2 * a);
            Console.WriteLine("The equation has two real roots: {0} and {1}", x1, x2);
        }


    }
}

