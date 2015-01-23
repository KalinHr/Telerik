using System;
using System.Globalization;

/*A beer time is after 1:00 PM and before 3:00 AM.
  Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59]
  and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time
  if the time cannot be parsed. Note: You may need to learn how to parse dates and times.*/

class BeerTime
{
    static void Main()
    {
        Console.Write("time: ");
        string time = Console.ReadLine();
        string[] pattern = { "hh:mm tt", "h:mm tt" };
        CultureInfo enUS = new CultureInfo("en-US");
        DateTime dateValue;

        if (DateTime.TryParseExact(time, pattern, enUS, DateTimeStyles.None, out dateValue))
        {
            if ((Convert.ToInt32(DateTime.Compare(DateTime.Parse("01:00 PM"), dateValue)) <= 0 &&
                Convert.ToInt32(DateTime.Compare(DateTime.Parse("11:59 PM"), dateValue)) >= 0) ||
                Convert.ToInt32(DateTime.Compare(DateTime.Parse("00:00 AM"), dateValue)) <= 0 &&
                (Convert.ToInt32(DateTime.Compare(DateTime.Parse("03:00 AM"), dateValue)) > 0))
                Console.WriteLine("beer time");
            else
                Console.WriteLine("non-beer time");
        }
        else
            Console.WriteLine("invalid time");
    }
}