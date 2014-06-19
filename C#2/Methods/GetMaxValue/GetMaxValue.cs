using System;

/* Write a method GetMax() with two parameters that returns the bigger of two integers.
 * Write a program that reads 3 integers from  * the console and prints the biggest of them using the method GetMax().*/

namespace GetMaxValue
{
    class GetMaxValue
    {
        static int GetMax(int number1, int number2)
        {
            int maxNumber = number1;
            if (number1 < number2)
            {
                maxNumber = number2;
            }
            return maxNumber;
        }

        static void Main()
        {
            Console.WriteLine("Please enter three numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("The biggest number is: {0} ", GetMax(a,GetMax(b,c)));
        }
    }
}


