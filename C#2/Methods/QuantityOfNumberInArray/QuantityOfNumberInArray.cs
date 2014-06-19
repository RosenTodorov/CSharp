using System;
/*Write a method that counts how many times given number appears in given  
 * array. Write a test program to check if the method is working correctly.*/
namespace QuantityOfNumberInArray
{
    class QuantityOfNumberInArray
    {
        static int CountsEqualNumber(int[] array, int number)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main()
        {
            Console.Write("Please enter your number: ");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[] { 2, 5, 6, 5, 5, 6, 3, 6, 5, 9, 10, 123, 32, 4, 6, 5 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.Write("Value {0} is appears {1} times", number, CountsEqualNumber(array, number));
            Console.WriteLine();
        }
    }
}

            

			 
			
    

  