using System;


//6.Write an expression that checks if given point (x,  y) is within a circle K(O, 5).


class Circle
{
    static void Main()
    {
        int x;
        int y;
        bool isNumber = false;

        do
        {
            Console.Write("Enter value for x :");
            isNumber = int.TryParse(Console.ReadLine(), out x);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);
        isNumber = false;

        do
        {
            Console.Write("Enter value for y :");
            isNumber = int.TryParse(Console.ReadLine(), out y);
            if (!isNumber)
            {
                Console.WriteLine("Invalid number!Please enter valid number.");
            }
        }
        while (!isNumber);

        bool isInCircle = (x * x) + (y * y) <= 25;
        bool isOutRectangle = ((x >= -1 && x <= 5) && (y < 1 || y > 5)) ^ (x < -1 || x > 5);  //expression that checks if the given point is out of rectangle

        if (isInCircle && isOutRectangle)
        {
            Console.WriteLine("The given point ({0},{1}) is within circle K((0,0),5) and out of rectangle.", x, y);
        }
        else if (isInCircle && !isOutRectangle)
        {
            Console.WriteLine("The given point ({0},{1}) is  within circle K((0,0),5), but is not out of rectangle", x, y);
        }
        else if (!isInCircle && isOutRectangle)
        {
            Console.WriteLine("The given point ({0},{1}) is not within circle K((0,0),5), but is out of rectangle", x, y);
        }
        else if (!isInCircle && !isOutRectangle)
        {
            Console.WriteLine("The given point ({0},{1}) is not within circle K((0,0),5) and is not out of rectangle", x, y);
        }
    }
}


