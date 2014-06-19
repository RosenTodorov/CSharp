using System;

/* Write a method that calculates the number of workdays between today and given date, passed as parameter. 
   Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array. */

namespace NumberOfWorkdays
{
    class NumberOfWorkdays
    {
        static void Main()
        {
            // input
            Console.Write("Enter a end date in YYYY/MM/DD format: ");
            string[] input = Console.ReadLine().Split('/');
            int day = int.Parse(input[2]);
            int month = int.Parse(input[1]);
            int year = int.Parse(input[0]);

            // main logic
            DateTime startDay = DateTime.Today;
            DateTime endDay = new DateTime(year, month, day);
            int timeLen = 0;
            timeLen = Math.Abs((endDay - startDay).Days);
            if (startDay > endDay)
            {
                startDay = endDay;
                endDay = DateTime.Today;
            }

            // Holydays
            DateTime[] holidays = 
        { 
            new DateTime(2013, 5, 6), 
            new DateTime(2013, 9, 6),    
            new DateTime (2013, 12, 24), 
            new DateTime(2013, 12,24),                               
            new DateTime(2013, 9,22), 
            new DateTime(2013, 11, 1),   
            new DateTime (2013, 12,26), 
            new DateTime (2013, 12, 31),                               
            new DateTime(2014, 1, 1),
            new DateTime (2014, 1,2),   
            new DateTime (2014,3,3),    
            new DateTime (2014,5,6),                    
            new DateTime(2014, 9, 6), 
            new DateTime (2014, 12, 24), 
            new DateTime(2014, 12,24),  
            new DateTime(2014, 9,22),                       
            new DateTime(2014, 11, 1),
            new DateTime (2014, 12,26), 
            new DateTime (2014, 12, 31)
        };       
            Console.WriteLine("The days between the periods are: {0}", timeLen);
            int workDayCounter = 0;
            bool isHoliday = false;

            // Day checker
            for (int i = 0; i < timeLen; i++)
            {
                startDay = startDay.AddDays(1);
                if (startDay.DayOfWeek != DayOfWeek.Sunday && startDay.DayOfWeek != DayOfWeek.Saturday)
                {
                    for (int j = 0; j < holidays.Length; j++)
                    {
                        if (startDay == holidays[j])
                        {
                            isHoliday = true;
                            break;
                        }
                    }

                    if (!isHoliday)
                    {
                        workDayCounter++;
                    }

                    isHoliday = false;
                }
            }
            Console.WriteLine("The working days are: {0}", workDayCounter);
        }
    }
}
