using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTheirValues
{
    class ExchangeTheirValues
    {
        static void Main()
        {
            int firstVariable = 5;
            int secondVariable = 10;
            Console.WriteLine(firstVariable + "," + secondVariable);
            int thirdVariable;
            thirdVariable = firstVariable;
            firstVariable = secondVariable;
            secondVariable = thirdVariable;
            Console.WriteLine(firstVariable + "," + secondVariable);
        }
    }
}
