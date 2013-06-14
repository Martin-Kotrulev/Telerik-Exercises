using System;
/*11. Write a program that prints all possible cards
 * from a standard deck of 52 cards (without jokers).
 * The cards should be printed with their English names. Use nested for loops and switch-case. */

class PrintAllCards
{
    static void Main()
    {
        string[] ranks = new string[] { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] cards = new string[] { "Two", "Three", "Four", "Five",
            "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        string[,] deck = new string[4, 13];

        for (int row = 0; row < ranks.Length; row++)
        {
            Console.WriteLine(ranks[row]);
            for (int col = 0; col < cards.Length; col++)
            {
                deck[row, col] = cards[col].PadRight(5, ' ') + " of " + ranks[row];
                Console.WriteLine(deck[row, col]);
            }
            Console.WriteLine();
        }
    }
}

