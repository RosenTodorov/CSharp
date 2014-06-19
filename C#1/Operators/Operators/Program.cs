using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class oddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();
            decimal num;
            decimal result;
            string output;

            //Do ... while tryparse is successful???

            if (Decimal.TryParse(userInput, out num))  // checks if written numbers are decimal
            {
                result = num % 2;
                if (result == 1)
                    output = "odd";
                else
                    output = "even";
                Console.WriteLine("Your number is: {0}", output);
            }
            else
            {
                Console.WriteLine("Your input is not number. Enter a number."); // if not number
            }
        }
    }
}
