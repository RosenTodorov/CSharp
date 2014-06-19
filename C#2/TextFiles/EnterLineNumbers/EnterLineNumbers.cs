using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program that reads a text file and inserts 
   line numbers in front of each of its lines. 
   The result should be written to another text file.*/

namespace EnterLineNumbers
{
    class EnterLineNumbers
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"../../TextFile.txt");
            StreamWriter writer = new StreamWriter(@"../../result.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    line = lineNumber + " " + line;
                    writer.WriteLine(line);
                    lineNumber++;
                    line = reader.ReadLine();
                }
                writer.Close();
            }
            // printing result, which is saved in another file, on the console        
            reader = new StreamReader(@"../../result.txt");
            using (reader)
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}

