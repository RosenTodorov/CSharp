using System;

 class BitAtPositionPHasValue1
 {
     static void Main()
     {
         Console.Write("Put your number:");
         int number = int.Parse(Console.ReadLine());
         Console.Write("Please put your number for the position p:");
         int position = int.Parse(Console.ReadLine());

         int mask = 1 << position;
         int result = mask & number;
         int bit = result >> position;

         Console.WriteLine("The bit of position p is:" + bit);

         if (bit == 1)
         {
             Console.WriteLine(true);
         }
         else if (bit == 0)
         {
             Console.WriteLine(false);
         }
         else
         {
             Console.WriteLine("Your program does not work");
         }
     }
 }

