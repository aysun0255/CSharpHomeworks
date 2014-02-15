using System;

/*
 * 11.* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven"
 */

class ConvertNumberToText
{
    static void Main()
    {
        Console.Write("Enter number to convert [0..999]:");
        int numberToConvert = int.Parse(Console.ReadLine());

        //for numbers from 0 to 19
        if (numberToConvert >= 0 && numberToConvert <= 19)
        {
            Console.WriteLine(ToNineteen(numberToConvert));
        }


        //for numbers from 19 to 100
        if (numberToConvert > 19 && numberToConvert <= 100 && numberToConvert % 10 == 0)
        {
            Console.WriteLine(ToHundred(numberToConvert));
        }
        else if (numberToConvert > 19 && numberToConvert < 100)
        {
            Console.WriteLine(ToHundred((numberToConvert / 10) * 10) + " " + ToNineteen(numberToConvert % 10));
        }



        //for numbers >100
        if (numberToConvert > 100 && numberToConvert <= 999 && numberToConvert % 100 == 0)
        {
            Console.WriteLine(ToNineteen(numberToConvert / 100) + " " + ToHundred(100));
        }
        else if (numberToConvert > 100 && numberToConvert <= 999)
        {
            Console.Write(ToNineteen(numberToConvert / 100) + " " + ToHundred(100) + " and ");

            if (numberToConvert % 100 <= 19)
            {
                Console.WriteLine(ToNineteen(numberToConvert % 100));
            }
            else
            {
                Console.WriteLine(ToHundred(((numberToConvert % 100) / 10) * 10) + " " + ToNineteen((numberToConvert % 100) % 10));
            }

        }

        // message for invalid entered value
        if (numberToConvert < 0 || numberToConvert > 999)
        {
            Console.WriteLine("You entered number that is not in the interval [0..999]");
        }


    }

    private static string ToHundred(int numberToConvert)
    {
        string convertedNumber = null;
        switch (numberToConvert)
        {
            case 20:
                convertedNumber = "twenty";
                break;
            case 30:
                convertedNumber = "thirty";
                break;
            case 40:
                convertedNumber = "fourty";
                break;
            case 50:
                convertedNumber = "fifty";
                break;
            case 60:
                convertedNumber = "sixty";
                break;
            case 70:
                convertedNumber = "seventy";
                break;
            case 80:
                convertedNumber = "eighty";
                break;
            case 90:
                convertedNumber = "ninety";
                break;
            case 100:
                convertedNumber = "hundred";
                break;
            default:
                Console.WriteLine("Error!Please enter correct value.");
                break;
        }
        return convertedNumber;
    }

    private static string ToNineteen(int numberToConvert)
    {
        string convertedNumber = null;
        switch (numberToConvert)
        {
            case 0:
                convertedNumber = "zero";
                break;
            case 1:
                convertedNumber = "one";
                break;
            case 2:
                convertedNumber = "two";
                break;
            case 3:
                convertedNumber = "three";
                break;
            case 4:
                convertedNumber = "four";
                break;
            case 5:
                convertedNumber = "five";
                break;
            case 6:
                convertedNumber = "six";
                break;
            case 7:
                convertedNumber = "seven";
                break;
            case 8:
                convertedNumber = "eight";
                break;
            case 9:
                convertedNumber = "nine";
                break;
            case 10:
                convertedNumber = "ten";
                break;
            case 11:
                convertedNumber = "eleven";
                break;
            case 12:
                convertedNumber = "twelve";
                break;
            case 13:
                convertedNumber = "thirteen";
                break;
            case 14:
                convertedNumber = "fourteen";
                break;
            case 15:
                convertedNumber = "fifteen";
                break;
            case 16:
                convertedNumber = "sixteen";
                break;
            case 17:
                convertedNumber = "seventeen";
                break;
            case 18:
                convertedNumber = "eighteen";
                break;
            case 19:
                convertedNumber = "nineteen";
                break;
            default:
                Console.WriteLine("Error!Please enter correct value.");
                break;
        }
        return convertedNumber;
    }
}

