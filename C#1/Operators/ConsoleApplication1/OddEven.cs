using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class OddEven
    {
        static void Main()
        {
            Console.Write("Input your number: ");
            int number = int.Parse(Console.ReadLine());
            int result = number % 2;
            Console.WriteLine(result == 0? "the number is even" : "the number is odd");
        }
    }
}
