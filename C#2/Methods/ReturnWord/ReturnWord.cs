using System;
/*Write a method that returns the last digit of given integer as an English 
 * word. Examples: 512  "two", 1024  "four", 12309  "nine".*/
namespace ReturnWord
{
    class ReturnWord // last digit to string
    {
        static void PrintLastDigitToString(int number)
        {
            int lastDigit = Math.Abs(number % 10); // i az otricatelni stoinosti ako vavejdame
            switch (lastDigit)
            {
                case 0: Console.WriteLine("{0}--> zero", number); break;
                case 1: Console.WriteLine("{0}--> one", number); break;
                case 2: Console.WriteLine("{0}--> two", number); break;
                case 3: Console.WriteLine("{0}--> three", number); break;
                case 4: Console.WriteLine("{0}--> four", number); break;
                case 5: Console.WriteLine("{0}--> five", number); break;
                case 6: Console.WriteLine("{0}--> six", number); break;
                case 7: Console.WriteLine("{0}--> seven", number); break;
                case 8: Console.WriteLine("{0}--> eight", number); break;
                case 9: Console.WriteLine("{0}--> nine", number); break;
            }
        }
        static void Main()
        {
            Console.Write("Please enter your number: ");
            int number = int.Parse(Console.ReadLine());
            PrintLastDigitToString(number);
        }
    }
}

    
        

    



