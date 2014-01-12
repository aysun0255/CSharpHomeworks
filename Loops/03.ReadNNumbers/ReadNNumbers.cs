using System;

/*
 *3.Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
 */
class ReadNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to read :");
        int n = int.Parse(Console.ReadLine());
        int largestNumber = 0;
        int smallestNumber = 0;
        int number = 0;

        if (n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (smallestNumber == 0 && largestNumber == 0)
                {
                    smallestNumber = number;
                }
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
                else if (smallestNumber == 0 && number <= smallestNumber)
                {
                    smallestNumber = number;
                }
                else if (smallestNumber == 0 && number < largestNumber)
                {
                    smallestNumber = number;
                }
                else if (smallestNumber == 0 && largestNumber == 0)
                {
                    smallestNumber = number;
                }
                else if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }
        }
        else
        {
            Console.WriteLine("You entered invalid value for numbers to read.");
        }


        if (n > 0)
        {
            Console.WriteLine("The largest number is :{0}", largestNumber);
            Console.WriteLine("The smallest number is :{0}", smallestNumber);
        }
    }
}
