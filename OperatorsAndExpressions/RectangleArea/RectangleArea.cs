using System;

/*
 * 3.Write an expression that calculates rectangle’s area by given width and height.
 */


class RectangleArea
{
    static void Main()
    {
        int width;
        bool isNumber = false;

        do
        {
            Console.Write("Enter width:");
            isNumber = int.TryParse(Console.ReadLine(), out width);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

       int height;
       isNumber = false;

        do
        {
            Console.Write("Enter height:");
            isNumber = int.TryParse(Console.ReadLine(), out height);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        int area = height * width;
        Console.WriteLine("Rectangle`s area is: {0}",area);
    }
}

