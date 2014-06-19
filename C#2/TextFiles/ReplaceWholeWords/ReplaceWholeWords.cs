using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

// Modify the solution of the previous problem to replace only whole words (not substrings).

class ReplaceWholeWords 
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
                    line = Regex.Replace(line, @"\bstart\b", "finish", RegexOptions.IgnoreCase);
                    writer.WriteLine(line);
                    line = reader.ReadLine(); 
                } 
            } 
        }
        Console.WriteLine("Result file generated!"); 
    } 
}