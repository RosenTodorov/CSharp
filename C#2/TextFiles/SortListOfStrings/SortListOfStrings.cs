using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program that reads a text file containing a list of strings, 
 * sorts them and saves them to another text file. */

namespace SortListOfStrings
{
    class SortListOfStrings
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"../../textFile.txt"))
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                StringBuilder sb = new StringBuilder();

                while (line != null)
                {
                    sb.AppendFormat("{0} ", line);
                    lineNumber++;
                    line = reader.ReadLine();
                }

                string[] words = sb.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(words);

                using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        writer.WriteLine(words[i]);
                    }
                }
            }
            Console.WriteLine("Result file generated!");
        }
    }
}
			

			 
			

