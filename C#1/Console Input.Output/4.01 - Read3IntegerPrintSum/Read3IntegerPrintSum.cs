using System;

class Read3IntegerPrintSum
    {
        static void Main()
        {
            Console.Write("Please put your first integer number:");
            string firstNumber = Console.ReadLine();
            int number1 = int.Parse(firstNumber);

            Console.Write("Please put your second integer number:");
            string secondNumber = Console.ReadLine();
            int number2 = int.Parse(secondNumber);

            Console.Write("Please put your third integer number:");
            string thirdNumber = Console.ReadLine();
            int number3 = int.Parse(thirdNumber);

            int sumNumbers = number1 + number2 + number3;
            Console.WriteLine("The sum of numbers are:" + " "+ sumNumbers);
        }
    }

