using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/* Write a program that compares two text files line by line and prints the number 
   of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.*/

namespace CompareLineByLine
{
    class CompareLineByLine
    {
        static void Main()
        {
            StreamReader readerFirstFile = new StreamReader(@"../../firstFile.txt");
            StreamReader readerSecondFile = new StreamReader(@"../../secondFile.txt");

            int equalLines = 0;
            int differentLines = 0;

            int lineNumber = 0;

            using (readerFirstFile)
            {
                using (readerSecondFile)
                {
                    while (true)
                    {
                        lineNumber++;
                        string lineFileOne = readerFirstFile.ReadLine();
                        string lineFileTwo = readerSecondFile.ReadLine();
                        if (lineFileOne == lineFileTwo)                       
                            equalLines++;                        
                        else                        
                            differentLines++;
                        
                        if (lineFileOne == null && lineFileTwo == null)
                            break;
                    }
                }
            }
            Console.WriteLine("Equal lines are {0}, and different are {1}", equalLines, differentLines);
        }
    }
}
                    



