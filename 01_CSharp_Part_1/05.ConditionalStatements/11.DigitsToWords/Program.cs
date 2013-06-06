using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number [0...999]: ");
        string strNum = Console.ReadLine();
        int number = int.Parse(strNum);
        bool hundreds = false;
        char secDig;
        int secondDigit = 0;
        int lastDigit = number % 10;
        string[] zeroToNine = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string[] twentyToNinety = { "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
        string[] exceptions = {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
                              "Eighteen", "Nineteen"};


        if ((number / 100) > 0)
        {
            secDig = strNum[1];
            secondDigit = (int)Char.GetNumericValue(secDig);
            hundreds = true;

            switch (number / 100)
            {
                case 1:
                    Console.Write(zeroToNine[1] + " Hundred ");
                    break;
                case 2:
                    Console.Write(zeroToNine[2] + " Hundred ");
                    break;
                case 3:
                    Console.Write(zeroToNine[3] + " Hundred ");
                    break;
                case 4:
                    Console.Write(zeroToNine[4] + " Hundred ");
                    break;
                case 5:
                    Console.Write(zeroToNine[5] + " Hundred ");
                    break;
                case 6:
                    Console.Write(zeroToNine[6] + " Hundred ");
                    break;
                case 7:
                    Console.Write(zeroToNine[7] + " Hundred ");
                    break;
                case 8:
                    Console.Write(zeroToNine[8] + " Hundred ");
                    break;
                case 9:
                    Console.Write(zeroToNine[9] + " Hundred ");
                    break;
                default:
                    break;
            }
        }

        if ((hundreds && secondDigit > 0) || (hundreds && lastDigit > 0))
        {
            Console.Write("and ");
        }

        if ((number / 100 == 0) || hundreds)
        {
            if (strNum.Length == 2)
            {
                secDig = strNum[0];
                secondDigit = (int)Char.GetNumericValue(secDig);
            }
            else if (strNum.Length == 3)
            {
                secDig = strNum[1];
                secondDigit = (int)Char.GetNumericValue(secDig);
            }

            switch (secondDigit)
            {
                case 2:
                    Console.Write(twentyToNinety[0]);
                    break;
                case 3:
                    Console.Write(twentyToNinety[1]);
                    break;
                case 4:
                    Console.Write(twentyToNinety[2]);
                    break;
                case 5:
                    Console.Write(twentyToNinety[3]);
                    break;
                case 6:
                    Console.Write(twentyToNinety[4]);
                    break;
                case 7:
                    Console.Write(twentyToNinety[5]);
                    break;
                case 8:
                    Console.Write(twentyToNinety[6]);
                    break;
                case 9:
                    Console.Write(twentyToNinety[7]);
                    break;
                default:
                    break;
            }
        }

        if ((secondDigit > 1 && hundreds) || strNum.Length == 1 || secondDigit == 0)
        {
            switch (lastDigit)
            {
                case 1:
                    Console.Write(zeroToNine[1]);
                    break;
                case 2:
                    Console.Write(zeroToNine[2]);
                    break;
                case 3:
                    Console.Write(zeroToNine[3]);
                    break;
                case 4:
                    Console.Write(zeroToNine[4]);
                    break;
                case 5:
                    Console.Write(zeroToNine[5]);
                    break;
                case 6:
                    Console.Write(zeroToNine[6]);
                    break;
                case 7:
                    Console.Write(zeroToNine[7]);
                    break;
                case 8:
                    Console.Write(zeroToNine[8]);
                    break;
                case 9:
                    Console.Write(zeroToNine[9]);
                    break;
                default:
                    break;
            }
        }

        if (strNum.Length == 2 && number > 9)
        {
            switch (number)
            {
                case 10:
                    Console.Write(exceptions[0]);
                    break;
                case 11:
                    Console.Write(exceptions[1]);
                    break;
                case 12:
                    Console.Write(exceptions[2]);
                    break;
                case 13:
                    Console.Write(exceptions[3]);
                    break;
                case 14:
                    Console.Write(exceptions[4]);
                    break;
                case 15:
                    Console.Write(exceptions[5]);
                    break;
                case 16:
                    Console.Write(exceptions[6]);
                    break;
                case 17:
                    Console.Write(exceptions[7]);
                    break;
                case 18:
                    Console.Write(exceptions[8]);
                    break;
                case 19:
                    Console.Write(exceptions[9]);
                    break;
                default:
                    break;
            }
        }

        if (number == 0)
        {
            Console.Write(zeroToNine[0]);
        }
        Console.WriteLine();
    }
}

