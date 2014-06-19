using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace how_old_you_will_be_after_10_years
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please write your age: ");
            int AgeNow = int.Parse(Console.ReadLine());
            if (AgeNow < 0 | AgeNow > 120)
            {
                Console.WriteLine("Your age was invalid!");
            }
            else
            {
                Console.WriteLine("Your age after 10 years will be: " + (AgeNow + 10));
              
            }
        }
    }
}
