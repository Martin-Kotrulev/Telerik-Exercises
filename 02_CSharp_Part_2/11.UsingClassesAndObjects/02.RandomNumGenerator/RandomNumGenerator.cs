using System;
/* 02. Write a program that generates and prints 
 * to the console 10 random values in the range [100, 200].*/

class RandomNumGenerator
{
    static void Main()
    {
        Random numGenerator = new Random();

        for (int i = 0; i < 10; i++)
        {
            int currentRandom = numGenerator.Next(100) + 100;
            Console.WriteLine(currentRandom);
        }
    }
}

