using System;



class GivenPointWithinCircleAndRectangle
 {
     static void Main()
     {
         Console.Write("Please put the coordinate of x:");
         decimal numberX = decimal.Parse(Console.ReadLine());
         Console.Write("Please put the coordiante of y:");
         decimal numberY = decimal.Parse(Console.ReadLine());
         bool circle = ((numberX - 1) * (numberX - 1)) + ((numberY - 1) * (numberY - 1)) <= 9m;
         bool rectangle = ((numberX >= -1) && (numberX <= 5)) && ((numberY >= -1) && (numberY <= 1));
             Console.WriteLine(circle ? "The point is within the circle" : "The point is outside of the circle");
             Console.WriteLine(rectangle ? "The point is within the rectangle" : "The point is outside of the rectangle");
     }
 }

