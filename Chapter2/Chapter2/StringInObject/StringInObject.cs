using System;

/*
 * 7.Declare two string variables and assign them with “Hello” and “World”. 
 * Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval).
 * Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/

class StringInObject
{
    static void Main()
    {
        string printHello = "Hello";
        string printWorld = "World";
        object concatenation = printHello + " " + printWorld;
        string newString = (string)concatenation;

        Console.WriteLine(concatenation);
        Console.WriteLine(newString);
    }
}

