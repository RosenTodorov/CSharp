using System;

class Program
    {
        static void Main()
        {
            Console.Write("Enter score in the range [1..9]:"); 
            int score = Int32.Parse(Console.ReadLine()); 
            
            switch (score)
            {
                case 1:
                case 2:
                case 3: 
                Console.WriteLine("Your new score is {0}", (score * 10)); 
                break;

                case 4:
                case 5:
                case 6: 
                Console.WriteLine("Your new score is {0}", (score * 100)); 
                break;

                case 7:
                case 8:
                case 9: 
                Console.WriteLine("Your new score is {0}", (score * 1000)); 
                break;

                default: 
                    Console.WriteLine("Error"); 
                    break;
            }
        }
    }

