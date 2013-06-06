using System;

class EmloyeesRecord
{
    static void Main()
    {
        string firstName = "Darth";
        string lastName = "Vader";
        char gender = 'M';
        long ID = 8801010101;
        int uniqueNum = 27560001;

        Console.WriteLine("Welcome to the Death Star!\nCurrent information is for employee " + 
            "with the Unique Number: {0}\nFirst Name: {1}\nLast Name: {2}\nGender: {3}\nID: {4}",
            uniqueNum,  firstName, lastName, gender, ID);
    }
}

