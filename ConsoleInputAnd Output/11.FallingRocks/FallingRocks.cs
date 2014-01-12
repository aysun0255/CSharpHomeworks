using System;
using System.Threading;

/*
 * 11.Implement the "Falling Rocks" game in the text console. 
 * A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys). 
 * A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density. The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
 *Implement collision detection and scoring system.
 */

class FallingRocks
{
    static void Main()
    {
        Console.Title = "Falling Rocks";
        Console.WindowWidth = 60;
        Console.BufferWidth = 60;
        Console.WindowHeight = 45;
        Console.BufferHeight = 45;

        string[] chars = { "+", ".", "@", ";", "+++", "--", "-" };
        string[] charYPosition = new string[45];
        int[] charXPosition = new int[45];
        Random randomChar = new Random();
        Random randomXPosition = new Random();
        SetRandomPosition(chars, charYPosition, charXPosition, randomChar, randomXPosition);//sets random position for char
        int dwarfX = 45;//dwarf x position
        int dwarfY = 44;//dwarf y position

        int x = 0;
        int y = 0;
        bool isAlive = true;
        int score = 0;
        while (true)
        {

            for (int i = 0; i < 45; i++)
            {
                y = i;
                x = charXPosition[y];
                if (y == 44 && (x == dwarfX || x == dwarfX + 1 || x == dwarfX + 2))
                {
                    isAlive = false;
                }
                Console.SetCursorPosition(x, y);
                Console.Write(charYPosition[y]);
            }
            if (Console.KeyAvailable)//reading keys from console
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow && dwarfX < 57)
                {
                    dwarfX++;
                }

                if (key.Key == ConsoleKey.LeftArrow && dwarfX > 0)
                {
                    dwarfX--;
                }
            }
            Console.SetCursorPosition(dwarfX, dwarfY);
            Console.Write("{0}");
            if (!isAlive)//
            {
                Console.SetCursorPosition(0, 44);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Game Over!Your score is : {0}. Press any key tor start again!", score);
                Console.ForegroundColor = ConsoleColor.White;

                Console.ReadKey();
                isAlive = true;
                score = 0;
                for (int i = charYPosition.Length - 1; i >= 0; i--)
                {
                    charYPosition[i] = null;
                    charXPosition[i] = 0;
                }
                SetRandomPosition(chars, charYPosition, charXPosition, randomChar, randomXPosition);

            }
            else
            {
                score++;

            }
            Thread.Sleep(150);
            for (int i = charYPosition.Length - 1; i > 0; i--)
            {
                charYPosition[i] = charYPosition[i - 1];
                charXPosition[i] = charXPosition[i - 1];
            }
            SetRandomPosition(chars, charYPosition, charXPosition, randomChar, randomXPosition);
            Console.Clear();
        }

    }

    private static void SetRandomPosition(string[] chars, string[] charYPosition, int[] charXPosition, Random randomChar, Random randomXPosition)
    {
        int randomCharNum = randomChar.Next(0, 6);
        charYPosition[0] = chars[randomCharNum];
        int randomX = randomXPosition.Next(0, 59);
        charXPosition[0] = randomX;
    }
}

