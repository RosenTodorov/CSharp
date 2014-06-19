using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.*/

namespace CalculatesDates
{
    class CalculatesDates
    {
        static void Main()
        {
            Console.Write("Please enter first date: ");
            string firstDate = Console.ReadLine();
            DateTime dateOne = DateTime.ParseExact(firstDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            Console.Write("Enter second date: "); 
            string secondDate = Console.ReadLine(); 
            DateTime dateTwo = DateTime.ParseExact(secondDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            TimeSpan days = dateOne - dateTwo;
            Console.WriteLine(days.Days);
        }
    }
}
