using System;

class SafeFloatCompare
{
    static void Main()
    {
        float var1 = 5.3f;
        float var2 = 6.01f;
        bool firstCompare = Math.Abs(var1 - var2) < 0.000001;
        Console.WriteLine("The compared numbers {0} and {1} are equal: {2}", var1, var2, firstCompare);

        double var3 = 5.00000001f;
        double var4 = 5.00000003f;
        bool secondCompare = Math.Abs(var3 - var4) < 0.000001;
        Console.WriteLine("The compared numbers {0} and {1} are equal: {2}", var3, var4, secondCompare);
    }
}

