using System;

class Ages
{
    static void Main()
    {
        Console.Write("Please enter your current age: ");
        byte inputAge = byte.Parse(Console.ReadLine());

        inputAge += 10;
        Console.WriteLine("After one decade you will be {0} years old!", inputAge);
    }
}