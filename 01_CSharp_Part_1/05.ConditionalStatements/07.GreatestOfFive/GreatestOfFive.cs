using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers and see which one is the greatest: ");
        int[] numbers = new int[5];
        int len = numbers.Length;
        int largest = numbers[0];

        for (int i = 0; i < len; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < len; i++)
        {
            if (largest < numbers[i])
            {
                largest = numbers[i];
            }
        }
        Console.WriteLine("The greatest of the five numbers is: {0}", largest);
    }
}

