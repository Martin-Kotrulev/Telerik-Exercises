using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter your score [1-9]: ");
        string input = Console.ReadLine();
        int score;
        bool check = int.TryParse(input, out score);
        string error = "ERROR!";

        if (check)
        {
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    score *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    score *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    score *= 1000;
                    break;
                default:
                    Console.WriteLine(error);
                    return;
            }
            Console.WriteLine("Final score: {0}", score);
        }
        else
        {
            Console.WriteLine(error);
        }
    }
}

