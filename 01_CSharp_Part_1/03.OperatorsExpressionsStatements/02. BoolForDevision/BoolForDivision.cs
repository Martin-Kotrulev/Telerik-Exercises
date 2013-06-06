using System;



class BoolForDivision
{
    static void Main()
    {
        Console.Write("Check if your number can be divided by 7 and 5 simultanesly: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(x % 35 == 0);
    }
}