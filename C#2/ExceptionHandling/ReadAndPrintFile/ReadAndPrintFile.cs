using System;
using System.IO;
using System.Text;
using System.Security;

/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
   reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
   Be sure to catch all possible exceptions and print user-friendly error messages. */
 
namespace ReadAndPrintFile
{
    class ReadAndPrintFile
    {
        static void Main()
        {
            try
            {
                string text = @"c:\temp\MyTest.txt";
                string readText = File.ReadAllText(text);
                Console.WriteLine(readText);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("File is null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is a zero-length string, contains only white space, or contains one or more invalid characters");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered path is too long");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The path is invalid");
            }
            catch (IOException) 
            { 
                Console.WriteLine("There was na error opening the file"); 
            }
            catch (UnauthorizedAccessException) 
            { 
                Console.WriteLine("There are access permission issues with the file"); 
            }
            catch (NotSupportedException) 
            { 
                Console.WriteLine("The path of the file is in an invalid format"); 
            }
            catch (SecurityException) 
            { 
                Console.WriteLine("There are access permission issues with the file"); 
            }  
        }
    }
}
