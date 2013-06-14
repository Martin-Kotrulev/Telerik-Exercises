using System;
/*03. Write a program that reads from the console
 *a sequence of N integer numbers and returns the minimal and maximal of them.*/

class PrintMinAndMaxInSequence
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers will be compared: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter {0} numbers:", n);
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int max = numbers[0];
        int min = numbers[0];

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Greatest: {0}, Smallest: {1}", max, min);

    }
}

