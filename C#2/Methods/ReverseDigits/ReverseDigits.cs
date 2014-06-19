using System;
//Write a method that reverses the digits of given decimal number. Example: 256  652
namespace ReverseDigits
{
    class ReverseDigits
    {
        static string NumberInReverse(decimal number)
        {
            string decimalToString = number.ToString();
            string result = "";

            for (int i = decimalToString.Length - 1; i >= 0; i--)
            {
                result = result + decimalToString[i];
            }
            result = result.TrimStart(' '); // maha simvola, koito sme mu zadali v skobite
            result = result.TrimStart('0');
            return result;
        }
        static void Main()
        {
            Console.Write("Please enter your decimal number: ");
            decimal number = decimal.Parse(Console.ReadLine());

            Console.WriteLine(NumberInReverse(number));
        }
    }
}


			
			 
