using System;

/*Write a program that reads a year from the console and checks whether it is a leap one.
  Use System.DateTime.
 */

class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        if (DateTime.IsLeapYear(year))
            Console.WriteLine("leap one");
        else
            Console.WriteLine("not leap");
    }
}