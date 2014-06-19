using System;

 class GreaterNumber
 {
     static void Main()
     {
         Console.Write("Please enter the first number:");
         int firstNumber = int.Parse(Console.ReadLine());

         Console.Write("Please enter the second number:");
         int secondNumber = int.Parse(Console.ReadLine());

         int greaterNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
         Console.WriteLine("The greater number is:" + greaterNumber);
     }
 }

