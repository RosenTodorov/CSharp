using System;

 class ExtractingBitValue
 {
     static void Main()
     {
         Console.Write("Put your integer number:");
         int intNumber = int.Parse(Console.ReadLine());
         Console.Write("Please put your bit number:");
         int bitNumber = int.Parse(Console.ReadLine());

         int mask = 1 << bitNumber;
         int result = mask & intNumber;
         int bitValue = result >> bitNumber;

         Console.WriteLine("The value of bit is:" + bitValue);   
     }
 }

