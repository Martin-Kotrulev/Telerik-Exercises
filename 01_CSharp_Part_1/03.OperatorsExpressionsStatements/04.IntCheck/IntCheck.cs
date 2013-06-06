using System;

class IntCheck
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int x = int.Parse(Console.ReadLine());

        // the formula to find if the third digit form lefto to right is 7:
        bool calculate = ((x / 100) % 10) == 7;

        Console.WriteLine("The third digit from right to left is 7: {0}", calculate);
    }
}

