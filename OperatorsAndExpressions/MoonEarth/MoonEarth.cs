using System;

class MoonEarth
{
    static void Main()
    {
        Console.Write("Enter weight on Earth (kg) :");
        float weightEarth = float.Parse(Console.ReadLine());
        float weightMoon = 0.17f * weightEarth;
        Console.WriteLine("Weight on Moon is : {0} kg", weightMoon);
    }
}

