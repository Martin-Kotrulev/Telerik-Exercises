using System;


class GreaterNumber
{
    static void Main()
    {
        Console.Write("Please enter the first number which must be compared: ");
        int firstNum = int.Parse(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        int greater = CompareNumbers(firstNum, secondNum);
        Console.WriteLine("The greater number is: ", greater);
    }
    // using method to determine which of the numbers is bigger (bitwise)
    static int CompareNumbers(int x, int y)
    {
        int greater = x - ((x - y) & ((x - y) >> 31));
        return greater;
    }
}

