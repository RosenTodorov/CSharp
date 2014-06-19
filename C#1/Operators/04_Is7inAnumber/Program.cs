using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Is7inAnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int num;

            if (int.TryParse(userInput, out num))
            {
                int num2 = num / 100;
                int modus = num2 % 10;
                if (modus == 7)
                {
                Console.WriteLine("The third number is 7");
                }
                else
                {
                Console.WriteLine("The third number is not 7");
                }
            }
            else
            {
                Console.WriteLine("Your input is invalid");
            }
        }
    }
}
