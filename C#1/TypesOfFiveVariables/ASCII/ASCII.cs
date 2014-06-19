using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class ASCII
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.ASCII;
            for (byte i = 0; i < 127; i++)
            {
                Console.WriteLine("Char number " + i + " is:" + (char)i);
            }
        }
    }
}
