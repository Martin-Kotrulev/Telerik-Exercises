using System;

class BoolForGender
{
    static void Main(string[] args)
    {
        bool isFemale = true;
        bool isMyGenderMale = true;
        Console.WriteLine(
            isMyGenderMale ^ isFemale ? "My gender is female!" : "My gender is male!");
    }
}
