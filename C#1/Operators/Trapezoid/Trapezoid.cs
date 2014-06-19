using System;
class Trapezoid
 {
     static void Main()
     {
        Console.Write("Please enter a value for 'a':");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Please enter a value for 'b':");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("Please enter a value for height:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("The trapezoid's area is:" + ((numberA + numberB) * height)/2);
     }
 }
