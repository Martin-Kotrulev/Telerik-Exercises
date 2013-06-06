using System;

class CompanyAndMenagerInfo
{
    static void Main()
    {
        string[] firm = new string[5];
        string[] manager = new string[4];
        string[] info = {"Name", "Phone Number", "Address", "Fax Number", "Website"};
        string[] infoManager = { "First Name", "Last Name", "Age", "Phone Number" };

        // reads elements of the info array and put the input in firm array;
        int length = info.Length;
 
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter the {0} of the firm: ", info[i]);
            firm[i] = Console.ReadLine();
        }
        Console.WriteLine();

        // reads element of the infoManager and put the input in manger array;
        length = infoManager.Length;

        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter the {0} of your manager: ", infoManager[i]);
            manager[i] = Console.ReadLine();
        }

        Console.WriteLine("INFORMATION FOR YOUR FIRM:\n");

        //print the information from firm array to the console;
        length = firm.Length;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("{0, -20}{1, 20}",info[i] , firm[i]);
        }

        Console.WriteLine("\nIFNORMATION FOR YOUR MANAGER:\n");

        //print the information from manager array to the console;
        length = manager.Length;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("{0, -20}{1, 20}", infoManager[i], manager[i]);
        }
        Console.WriteLine();
    }
}


