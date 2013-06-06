using System;

class TwoStringInObject
{
    static void Main()
    {
        string firstWord = "Hello,";
        string secondWord = "World!";
        object concatWords = firstWord + " " + secondWord;
        string helloWorld = (string)concatWords;
        Console.WriteLine(concatWords);
    }
}
