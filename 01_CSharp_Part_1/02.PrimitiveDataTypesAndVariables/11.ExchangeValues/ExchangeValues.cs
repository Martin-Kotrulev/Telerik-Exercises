using System;

class ExchangeValues
{
    static void Main()
    {
        int firstNum = 5;
        int secondNum = 10;
        Console.WriteLine("We have first integer = {0} and second integer = {1}",
            firstNum, secondNum);

        int changeNum = firstNum;
        firstNum = secondNum;
        secondNum = changeNum;
        Console.WriteLine("After exchange first integer = {0} and second integer = {1}",
            firstNum, secondNum);
    }
}

