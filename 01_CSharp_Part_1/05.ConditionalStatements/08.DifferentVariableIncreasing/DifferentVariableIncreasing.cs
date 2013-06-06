using System;

class DifferentVariableIncreasing
{
    static void Main()
    {
        Console.WriteLine("Enter something :P");
        string input = Console.ReadLine();
        int intTest;
        double doubleTest;
        bool intType = int.TryParse(input, out intTest);
        bool doubleType = double.TryParse(input, out doubleTest);

        if (intType)
        {
            Console.WriteLine("The input of type: \"int\" and the result is: {0}", intTest + 1);
        }
        else if (doubleType)
        {
            Console.WriteLine("The input of type: \"double\" and the result is: {0}", doubleTest + 1);
        }
        else 
        {
            Console.WriteLine("The input of type: \"string\" and the result is: {0}", input + "*");
        }

    }
}

