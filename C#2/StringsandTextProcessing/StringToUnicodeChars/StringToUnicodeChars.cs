using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.*/

namespace StringToUnicodeChars
{
    class StringToUnicodeChars
    {
        static void Main()
        {
            string text = "Hi !";
            StringBuilder sb = new StringBuilder(text.Length * 6);

            for (int i = 0; i < text.Length; i++)
            {
                sb.AppendFormat("\\u{0:X4}", (int)text[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
