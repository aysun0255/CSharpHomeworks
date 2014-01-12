using System;

/*
 * 10.Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
 */

class CalculateSum
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        // Initialize
        double sum = 1;
        double oldSum = 0;

        // Calculate sum with precision 0.001
        for (int i = 2; Math.Abs(sum - oldSum) > 0.001; i++)
        {
            if (i % 2 == 0)
            {
                oldSum = sum;
                sum = sum + 1.0 / i;
            }
            else
            {
                oldSum = sum;
                sum = sum - 1.0 / i;
            }
        }

        // Print result
        Console.WriteLine("{0:F3}", sum);
    }
}

