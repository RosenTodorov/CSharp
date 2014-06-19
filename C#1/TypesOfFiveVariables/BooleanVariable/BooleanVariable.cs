using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            Console.WriteLine("Are you a female? yes or no:");
            string input = Console.ReadLine();
            bool isFemale = (input == "yes");
            if (isFemale == true)
            {
                Console.WriteLine("You are female");
            }
            else
            {
                Console.WriteLine("You are not Female");
            }
        }
    }
}
