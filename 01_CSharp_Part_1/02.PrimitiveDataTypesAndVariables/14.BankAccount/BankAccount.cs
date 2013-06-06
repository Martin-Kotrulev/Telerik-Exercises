using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Michael";
        string middleName = "Christopher";
        string lastName = "Lee";
        Console.WriteLine("Bank account user: {0} {1} {2}", firstName, middleName, lastName);

        decimal moneyBalance = 34000.50m;
        Console.WriteLine("Current balance of the accound: {0}", moneyBalance);

        string bankName = "UniverseBank";
        string IBAN = "BG21 UNIB 9854 3452 2435 03";
        string BIC = "UNIVBNCR";
        Console.WriteLine("Name of the bank: {0}\nIBAN: {1}\nBIC: {2}", bankName, IBAN, BIC);

        long cardOne = 3421543268713564;
        long cardTwo = 5423876414369054;
        long cardThree = 9483205893709016;
        // using custom numeric format;
        Console.WriteLine(
            "\nCredit cards associated with this account:\n{0:#### #### #### ####}" + 
            "\n{1:#### #### #### ####}\n{2:#### #### #### ####}",
            cardOne, cardTwo, cardThree);
    }
}

