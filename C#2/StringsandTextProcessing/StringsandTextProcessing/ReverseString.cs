using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads a string, reverses it and prints the result at the console.Example: "sample"  "elpmas".

namespace StringsandTextProcessing
{
    class ReverseString
    {
        static void Main()
        {
            string text = "lebed";
            string reversed = ReverseText(text);
            Console.WriteLine(reversed);
            
        }

        public static string ReverseText(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = text.Length - 1;  i >= 0; i--)
            {
                sb.Append(text[i]);
            }

                return sb.ToString();
            }
        }
    }

