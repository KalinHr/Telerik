using System;
using System.Collections.Generic;

/*Write a method that calculates the number of workdays between today and given date, passed as parameter.
  Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
  preliminary as array.*/

class Program
{
    static int Workdays(List<DateTime> holidays)
    {
        Console.Write("year = ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("month = ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("day = ");
        int day = int.Parse(Console.ReadLine());
        int workdays = 0;
        DateTime lastDate = new DateTime(year, month, day);
        for (DateTime i = DateTime.Today; i <= lastDate; i = i.AddDays(1))
        {
            if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday)
            {
                bool flag = true;
                foreach (DateTime date in holidays)
                    if (i == date)
                        flag = false;
                if (flag)
                    workdays++;
            }
        }
        return workdays;
    }

    static void Main()
    {
        var holidays = new List<DateTime>()
        {
        new DateTime(2015, 3, 3),
        new DateTime(2015, 5, 1),
        };

        Console.WriteLine(Workdays(holidays));
    }
}