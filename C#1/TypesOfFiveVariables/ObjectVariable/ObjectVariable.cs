using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectVariable
{
    class ObjectVariable
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object concatenation = (hello + " " + world);
            Console.WriteLine(concatenation);
            string helloworld = (string)concatenation;
            Console.WriteLine(helloworld);
        }
    }
}
