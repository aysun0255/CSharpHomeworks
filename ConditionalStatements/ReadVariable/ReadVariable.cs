using System;

/*
 * 8.Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end.
 * The program must show the value of that variable as a console output. Use switch statement.
 */
class ReadVariable
{
    static void Main()
    {
        Console.Write("Enter what type of variable you want to read (string,double,int) :");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "string":
                Console.WriteLine("Enter value for string variable :");
                string stringVar = Console.ReadLine();
                Console.WriteLine(stringVar + "*");
                break;
            case "double":
                Console.WriteLine("Enter value for double variable :");
                double doubleVar = double.Parse(Console.ReadLine());
                doubleVar++;
                Console.WriteLine(doubleVar);
                break;
            case "int":
                Console.WriteLine("Enter value for integer variable :");
                int intVar = int.Parse(Console.ReadLine());
                intVar++;
                Console.WriteLine(intVar);
                break;
            default:
                Console.WriteLine("You entered invalid value for choice!");
                break;
        }
    }
}

