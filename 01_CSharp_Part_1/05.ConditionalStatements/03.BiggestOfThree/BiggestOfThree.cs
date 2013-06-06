using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Please enter three numbers to see which one is greatest:");
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        int thirdNum = int.Parse(Console.ReadLine());
        int biggest = 0;

        if (firstNum > secondNum && firstNum > thirdNum)
        {
            biggest = firstNum;
        }
        else if (secondNum > firstNum && secondNum > firstNum)
        {
            biggest = secondNum;
        }
        else if (thirdNum > firstNum && thirdNum > secondNum)
        {
            biggest = thirdNum;
        }

        if (firstNum == secondNum || firstNum == thirdNum || secondNum == thirdNum)
        {
            if ((firstNum == secondNum) && (firstNum < thirdNum))
            {
                biggest = thirdNum;
            }
            else if ((firstNum == thirdNum) && (firstNum < secondNum))
            {
                biggest = secondNum;
            }
            else if ((secondNum == thirdNum) && (secondNum < firstNum))
            {
                biggest = firstNum;
            }
            else if (firstNum == secondNum && firstNum == thirdNum)
            {
                Console.WriteLine("The three numbers are all equal!");
                return;
            }
        }
        Console.WriteLine("{0} is the biggest of the three numbers!", biggest);
    }
}

