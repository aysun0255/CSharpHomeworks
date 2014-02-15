using System;

/*
 * 10.Write a program that applies bonus scores to given scores in the range [1..9].
 * The program reads a digit as an input. 
 * If the digit is between 1 and 3, the program multiplies it by 10;
 * if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000.
 * If it is zero or if the value is not a digit, the program must report an error.
 *Use a switch statement and at the end print the calculated new value in the console.
 */

class BonusPoints
{
    static void Main()
    {
        Console.Write("Enter points (1-9):");
        int points = int.Parse(Console.ReadLine());

        switch (points)
        {
            case 1:
            case 2:
            case 3:
                points = points * 10;
                Console.WriteLine("Points + bonuses : {0}",points);
                break;
            case 4:
            case 5:
            case 6:
                points = points * 100;
                Console.WriteLine("Points + bonuses : {0}", points);
                break;
            case 7:
            case 8:
            case 9:
                points = points * 1000;
                Console.WriteLine("Points + bonuses : {0}", points);
                break;
            default:
                Console.WriteLine("You entered invalid value for points.Points must be in the interval (1..9).");
                break;
        }

    }
}

