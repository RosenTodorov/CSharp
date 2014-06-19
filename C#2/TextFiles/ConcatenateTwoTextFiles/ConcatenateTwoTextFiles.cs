using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that concatenates two text files into another text file.

namespace ConcatenateTwoTextFiles
{
    class ConcatenateTwoTextFiles
    {
        static void Main()
        {
            string textOne = "";
            string textTwo = "";
            string text = textOne + textTwo;
            try
            {
                StreamReader reader = new StreamReader(@"../../FirstTextFile.txt");
                using (reader)
                {
                    textOne = reader.ReadToEnd();
                }

                reader = new StreamReader(@"../../SecondTextFile.txt");
                using (reader)
                {
                    textTwo = reader.ReadToEnd();
                }
                ConcatenatesTwoStrings(textOne, textTwo);  
             
            }
            catch
            {
                Console.WriteLine("Something is wrong. Check file paths ot file contents.");
            }
        }


        static void ConcatenatesTwoStrings(string oneString, string twoString)
        {
            bool exist = false;

            try
            {
                exist = File.Exists(@"../../result.txt");
                StreamWriter write = new StreamWriter(@"../../result.txt");

                using (write)
                {
                    write.Write(oneString + Environment.NewLine + twoString);
                }
            }
            catch
            {
                Console.WriteLine("Something is wrong. Check file paths ot file contents.");
            }
            finally
            {
                if (exist)
                    Console.WriteLine("Text file \"result.txt\" re-created!");
                else
                    Console.WriteLine("Text file \"result.txt\" created!");
            }
        }
    }
}
                

          
           


            

        


      















