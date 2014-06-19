using System;

 class ExchangesOfBits
 {
     static void Main()
     {
         Console.WriteLine("Please enter your number:");
         int number = int.Parse(Console.ReadLine());

         int mask = 1 << 3;
         int thirdBit = (number & mask) >> 3;

         mask = 1 << 24;
         int twentyForthBit = (number & mask) >> 24;

         if (thirdBit == twentyForthBit)
         {
             Console.WriteLine(number);
             return;
         }

         if (thirdBit == 0)
         {
             //put 0 in 24th position
             mask = ~(1 << 24);
             number = mask & number;
         }
         else if (thirdBit == 1)
         {
             //put 1 in 24th position
             mask = 1 << 24;
             number = mask | number;
         }

         if (twentyForthBit == 0)
         {
             //put 0 in 3th position
             mask = ~(1 << 3);
             number = mask & number;
         }
         else if (twentyForthBit == 1)
         {
             //put 1 in 3th position
             mask = 1 << 3;
             number = mask | number;
         }
         Console.WriteLine(Convert.ToString(number,2).PadLeft(32, '0'));
         
         mask = 1 << 4;
         int fourthBit = (number & mask) >> 4;

         mask = 1 << 25;
         int twentyFifth = (number & mask) >> 25;

         if (fourthBit == twentyFifth)
         {
             Console.WriteLine(number);
             return;
         }

         if (fourthBit == 0)
         {
             //put 0 in 25th position
             mask = ~(1 << 25);
             number = mask & number;
         }
         else if (fourthBit == 1)
         {
             //put 1 in 25th position
             mask = 1 << 25;
             number = mask | number;
         }

         if (twentyForthBit == 0)
         {
             //put 0 in 4th position
             mask = ~(1 << 4);
             number = mask & number;
         }
         else if (twentyFifth == 1)
         {
             //put 1 in 4th position
             mask = 1 << 4;
             number = mask | number;
         }
         Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

         mask = 1 << 5;
         int FifthBit = (number & mask) >> 5;

         mask = 1 << 26;
         int twentySixBit = (number & mask) >> 26;

         if (FifthBit == twentySixBit)
         {
             Console.WriteLine(number);
             return;
         }

         if (FifthBit == 0)
         {
             //put 0 in 26th position
             mask = ~(1 << 26);
             number = mask & number;
         }
         else if (FifthBit == 1)
         {
             //put 1 in 26th position
             mask = 1 << 26;
             number = mask | number;
         }

         if (twentySixBit == 0)
         {
             //put 0 in 5th position
             mask = ~(1 << 5);
             number = mask & number;
         }
         else if (twentyFifth == 1)
         {
             //put 1 in 5th position
             mask = 1 << 5;
             number = mask | number;
         }
         Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
     }
 }

