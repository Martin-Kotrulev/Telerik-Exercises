using System;

class SumWithAccuracy
{
    static void Main()
    {
        double sum = 1.0f;

        for (double next = 2; 1 / next >= 0.001; next++)
        {
            if (next % 2 == 0)
            {
                sum = sum + (1 / next);
            }
            else
            {
                sum = sum - (1 / next);
            }
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}

