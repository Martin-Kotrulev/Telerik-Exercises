using System;
/* 05. Write a method that calculates the number of workdays 
 * between today and given date, passed as parameter. 
 * Consider that workdays are all days from Monday to Friday 
 * except a fixed list of public holidays specified preliminary as array.*/


class WorkDaysCalculator
{
    private static DateTime[] Holidays = {new DateTime(2013, 12, 25),
                                         new DateTime(2013, 12, 24), 
                                         new DateTime(2013, 1, 1), 
                                         new DateTime(2013, 5, 1),
                                         new DateTime(2013, 9, 17)};

    static void Main()
    {
        Console.Write("Enter a date to calculate the " + 
            "time span \nbetween today and your date in format [YYYY.MM.DD]: ");
        string[] date = Console.ReadLine().Split('.');

        int day = int.Parse(date[2]);
        int month = int.Parse(date[1]);
        int year = int.Parse(date[0]);

        DateTime currentDate = DateTime.Today;
        DateTime futureDate = new DateTime(year, month, day);
        int daysInterval = (futureDate - currentDate).Days;

        //Console.WriteLine(daySpan);
        int workDays = 0;
        bool isHoliday = false;
        for (int i = 0; i < daysInterval; i++)
        {
            currentDate = currentDate.AddDays(1);
            if (currentDate.DayOfWeek != DayOfWeek.Saturday &&
                currentDate.DayOfWeek != DayOfWeek.Sunday)
            {
                for (int j = 0; j < Holidays.Length; j++)
                {
                    if (currentDate == Holidays[j])
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    workDays++;
                }
                isHoliday = false;
            }
        }
        Console.WriteLine("Workdays in the interval: {0}", workDays);
    }
}

