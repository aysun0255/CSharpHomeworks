using System;

/*
 * 
 * 11.Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
 * The cards should be printed with their English names. Use nested for loops and switch-case.
 */

class PlayingCards
{
    static void Main()
    {
        string[] cardSuit = { "spades", "hearts", "diamonds", "clubs" };
        for (int i = 0; i < 4; i++)
        {
            for (int n = 1; n < 13; n++)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Ace of {0}", cardSuit[i]);
                        break;
                    case 2:
                        Console.WriteLine("2 of {0}", cardSuit[i]);
                        break;
                    case 3:
                        Console.WriteLine("3 of {0}", cardSuit[i]);
                        break;
                    case 4:
                        Console.WriteLine("4 of {0}", cardSuit[i]);
                        break;
                    case 5:
                        Console.WriteLine("5 of {0}", cardSuit[i]);
                        break;
                    case 6:
                        Console.WriteLine("6 of {0}", cardSuit[i]);
                        break;
                    case 7:
                        Console.WriteLine("7 of {0}", cardSuit[i]);
                        break;
                    case 8:
                        Console.WriteLine("8 of {0}", cardSuit[i]);
                        break;
                    case 9:
                        Console.WriteLine("9 of {0}", cardSuit[i]);
                        break;
                    case 10:
                        Console.WriteLine("Jack of {0}", cardSuit[i]);
                        break;
                    case 11:
                        Console.WriteLine("Queen of {0}", cardSuit[i]);
                        break;
                    case 12:
                        Console.WriteLine("King of {0}", cardSuit[i]);
                        break;
                    default:
                        Console.WriteLine("You entered invalid value for switch.");
                        break;
                }

            }
        }
    }
}

