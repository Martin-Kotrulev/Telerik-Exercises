using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter the height of the trapezoid: ");
        int h = int.Parse(Console.ReadLine());

        Console.Write("Enter side \"a\" of the trapezoid: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter side \"a\" of the trapezoid: ");
        int b = int.Parse(Console.ReadLine());

        //the formula for trapezoid area:
        double area = ((a + b) / 2)*h;

        Console.WriteLine("The area of the trapezoid is {0}", area);
    }
}
