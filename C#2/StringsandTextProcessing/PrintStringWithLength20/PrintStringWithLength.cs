using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that reads from the console a string of maximum 20 characters. 
  If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
  Print the result string into the console.*/

namespace PrintStringWithLength20
{
    class PrintStringWithLength
    {
        static void Main()
        {
            Console.WriteLine("Please input string with maximum lenght of 20 charachters: ");
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                input = input.PadRight(20, '*');
            }
            Console.WriteLine(input);
        }
    }
}
