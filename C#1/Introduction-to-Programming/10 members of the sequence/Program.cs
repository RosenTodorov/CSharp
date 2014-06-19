using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_members_of_the_sequence
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                  Console.WriteLine(i + ", ");
                }
                else
                {
                  Console.WriteLine(-i + ", ");
                }
             }
        }
    }
}
