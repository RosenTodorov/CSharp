using System;
using System.Numerics;

class FibonacciSequence
    {

 static void Main()
 {
     BigInteger firstMember = 0;
     BigInteger secondMember = 1;

     for (int count = 0; count < 98; count++)
     {
         Console.WriteLine(firstMember);
         BigInteger sum = firstMember + secondMember;
         firstMember = secondMember;
         secondMember = sum;
     }
     }
 }


