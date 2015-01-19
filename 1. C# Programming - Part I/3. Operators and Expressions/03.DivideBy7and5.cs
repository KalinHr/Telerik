using System;

/*Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

class DivideBy7and5
{
    static void Main()
    {
        Console.Write("number = ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool devided = false;
        if (number % 5 == 0 && number % 7 == 0)
            devided = true;
        Console.WriteLine(devided);
    }
}

