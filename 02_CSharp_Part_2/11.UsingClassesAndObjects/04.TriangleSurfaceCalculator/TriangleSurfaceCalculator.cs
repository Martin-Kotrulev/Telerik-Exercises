using System;
/* 04. Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; Three sides; 
 * Two sides and an angle between them. Use System.Math.*/


class TriangleSurfaceCalculator
{
    static double CalculateForTwoSidesAndAngle(double a, double b, double y)
    {
        double inDegrees = Math.PI * y / 180; 
        return (a * b * Math.Sin(inDegrees)) / 2;
    }

    static double CalculateForSideAndAltitude(double a, double h)
    {
        return (a * h) / 2;
    }

    static double CalculateForThreeSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static void Main()
    {
        Console.WriteLine(CalculateForSideAndAltitude(5, 5));
        Console.WriteLine(CalculateForThreeSides(5, 5, 7));
        Console.WriteLine(CalculateForTwoSidesAndAngle(5, 5, 90));
    }
}

