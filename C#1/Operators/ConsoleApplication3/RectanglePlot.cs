using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class RectanglePlot
    {
        static void Main()
        {
            Console.WriteLine("Write your numbers of width:");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your number of height");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("The rectancle's are is:" + height * width);
        }
    }
}
