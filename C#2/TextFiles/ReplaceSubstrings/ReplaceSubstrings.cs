/*Write a program that replaces all occurrences of the substring "start" with the substring  
 * "finish" in a text file. Ensure it will work * with large files (e.g. 100 MB).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceSubstrings
{
    class ReplaceSubstrings
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"../../textFile.txt"))
            {
                string line = reader.ReadLine();
                using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
                {
                    while (line != null)
                    {
                        line = Regex.Replace(line, "start", "finish", RegexOptions.IgnoreCase);
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                    writer.Close();
                }
            }
            Console.WriteLine("Result file generated!");
        }
    }
}