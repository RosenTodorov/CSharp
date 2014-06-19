using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValues
{
    class NullValues
    {
        static void Main()
        {
            int? someInt = null;
            double? someDouble = null;
            Console.WriteLine("These are null: Integer= " + someInt + " and Double " + someDouble);
            someInt = 6;
            someDouble = 1.8;
            Console.WriteLine("The same variables with values: Integer= " + someInt + " and Double " + someDouble); 
        }
    }
}
