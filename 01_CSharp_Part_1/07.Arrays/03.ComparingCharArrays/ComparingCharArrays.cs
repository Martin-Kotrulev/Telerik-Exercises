using System;
/* 03.Write a program that compares two char arrays 
 * lexicographically (letter by letter).*/

class ComparingCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the two char arrays: ");
        int firstArrLength = int.Parse(Console.ReadLine());
        int secondArrLength = int.Parse(Console.ReadLine());
        char[] charArray1 = new char[firstArrLength];
        char[] charArray2 = new char[secondArrLength];

        for (int i = 0; i < firstArrLength; i++)
        {
            Console.Write("Char element {0} of the first array: ", i);
            charArray1[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 0; i < secondArrLength; i++)
        {
            Console.Write("Char element {0} of the second array: ", i);
            charArray2[i] = char.Parse(Console.ReadLine());
        }

        if (firstArrLength == secondArrLength)
        {
            int length = firstArrLength;
            string winner = "";

            for (int i = 0; i < length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    winner = "Lexicographically, the " + (charArray1[i] < charArray2[i] ?
                        "First Array" : "Second Array") + " is earlier!";
                }
            }
            Console.WriteLine(winner);
        }
        else
        {
            Console.WriteLine(firstArrLength < secondArrLength ?
                "The first array comes earlier in the chart!" :
                "The second array comes earlier in the chart!");
        }
    }
}

