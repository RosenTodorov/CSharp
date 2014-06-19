using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareFloatingPointNumber
{
    class CompareFloatingPointNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            string number2 = Console.ReadLine();

            decimal number1dec;
            decimal number2dec;
            bool result;
            if (Decimal.TryParse(number1, out number1dec) && Decimal.TryParse(number2, out number2dec))
            {
                result = Math.Round(number1dec, 6) == Math.Round(number2dec, 6);
                Console.WriteLine("Your result is: {0}", result);
            }
            else
            {
                Console.WriteLine("Error. Your input is not number.");
            }
        }
    }
}
