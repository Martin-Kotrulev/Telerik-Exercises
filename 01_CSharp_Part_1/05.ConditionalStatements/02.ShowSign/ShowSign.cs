using System;


class ShowSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers: ");
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        byte signMinus = 0;

        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            Console.WriteLine("The product of the three numbers is \"0\"!");
        }

        if (firstNum < 0)
        {
            signMinus++;
        }

        if (secondNum < 0)
        {
            signMinus++;
        }

        if (thirdNum < 0)
        {
            signMinus++;
        }

        if (signMinus == 1 || signMinus == 3)
        {
            Console.WriteLine("The product of the three integers is with sign \"-\"!");
        }
        else
        {
            Console.WriteLine("The product of the three integers is with sign \"+\"!");
        }
    }
}

