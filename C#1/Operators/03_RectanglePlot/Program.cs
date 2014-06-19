using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RectanglePlot
{
    class Program
    {
        static void Main(string[] args)
        {
            string width = Console.ReadLine();
            string height = Console.ReadLine();
            decimal userWidth;
            decimal userHeight;

            if (decimal.TryParse(width, out userWidth) && decimal.TryParse(height, out userHeight))
            {
                Console.WriteLine("The area is:" + userHeight * userWidth);
            }
            else
            {
                Console.WriteLine("Your input is invalid");
            }
        }
    }
}
