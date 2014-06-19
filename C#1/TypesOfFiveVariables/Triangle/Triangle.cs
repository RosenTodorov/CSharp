using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        static void Main()
        {
            char copyrightSymbol = '\u00a9';
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(copyrightSymbol);
            Console.Write(copyrightSymbol); Console.WriteLine(copyrightSymbol);
            Console.Write(copyrightSymbol); Console.Write(copyrightSymbol); Console.WriteLine(copyrightSymbol);
            Console.Write(copyrightSymbol); Console.WriteLine(copyrightSymbol);
            Console.WriteLine(copyrightSymbol);
        }
    }
}
