using System;

/*Write a program that reads an integer number and calculates and prints its square root. If the number is invalid  
  or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.*/

namespace ExceptionHandling
{
    class CalculateSquareRoot
    {
        static void Main()
        {
            string number = Console.ReadLine();

            try
            {
                double stringNumber = double.Parse(number);
                if (stringNumber < 0 || stringNumber == 0)
                {
                    throw new ArgumentException(); //Ако парсването не мине, методът сам си хвърля изключение и затова няма нужда да хвърлям и аз - само трябва да го хвана. 
                }
                Console.WriteLine(Math.Sqrt(stringNumber));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentException)  //Хвърлям изключение: ArgumentException след проверката за отрицателно число, защото ако не хвърля, то MAath.SQRT си смята и извежда NaN. 
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}

