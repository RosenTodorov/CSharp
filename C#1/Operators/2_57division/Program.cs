using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_57division
{
    class division57
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();
            decimal num;
            decimal result;
            string output;

            if (Decimal.TryParse(userInput, out num))
            {
                result = (num/35)%2;
                if (result == 0)
                {
                    Console.WriteLine("Your number can be divided by 5 and 7");
                }
                else
                {
                    Console.WriteLine("Your number cannot be divided by 5 and 7");
                }
            }
            else
            {
                Console.WriteLine("Your input is not number. Enter a number."); // if not number
            }
                
        }
    }
}
