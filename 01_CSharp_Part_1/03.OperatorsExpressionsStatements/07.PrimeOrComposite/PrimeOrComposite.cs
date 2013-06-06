using System;

class PrimeOrComposite
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        bool prime = true;
        int upper = number * number;

        for (int i = 2; i <= upper; i++)
        {
            //using bitwise operation to determine if it is prime or composite;
            if ((number & i) == 0)
            {
                prime = false;
                break;
            }
        }
        Console.WriteLine("The number {0} is {1}", number, (prime ? "prime!" : "composite!"));
    }
}
