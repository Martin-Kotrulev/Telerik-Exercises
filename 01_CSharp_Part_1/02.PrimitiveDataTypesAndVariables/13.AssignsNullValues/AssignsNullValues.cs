using System;

class AssignsNullValues
{
    static void Main()
    {
        // directly assigns int value;
        int firstNum = 25;
        int? nullInt = firstNum;
        Console.WriteLine(firstNum);

        // assigns nullable type value;
        Console.WriteLine(nullInt.HasValue);
        firstNum = nullInt.Value; 
        Console.WriteLine(firstNum);

        double secondNum = 5.3453;
        double? nullDouble = null;
        Console.WriteLine(secondNum);
        Console.WriteLine(nullDouble.HasValue);

        // assigns null value or default;
        secondNum = nullDouble.GetValueOrDefault();
        Console.WriteLine(secondNum);
    }
}

