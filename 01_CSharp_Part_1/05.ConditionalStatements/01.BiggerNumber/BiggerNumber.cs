using System;


class BiggerNumber
{
    static void Main()
    {
        Console.Write("Please enter two numbers: ");

        int smallerNumber = int.Parse(Console.ReadLine());
        int biggerNumber = int.Parse(Console.ReadLine());
        int swap;

        if (smallerNumber == biggerNumber)
        {
            Console.WriteLine("{0} equals {1}", smallerNumber, biggerNumber);
        }
        else if (smallerNumber > biggerNumber)
        {
            swap = biggerNumber;
            biggerNumber = smallerNumber;
            smallerNumber = swap;
        }
        Console.WriteLine("{0} is greater than {1}!", biggerNumber, smallerNumber);
    }
}

