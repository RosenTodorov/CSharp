using System;

 class QuadraticEquation
 {
     static void Main()
     {
         Console.Write("Please enter the coefficient \"a\":");
         double a = double.Parse(Console.ReadLine());

         Console.Write("Please enter the coefficient \"b\":");
         double b = double.Parse(Console.ReadLine());

         Console.Write("Please enter the coefficient \"c\":");
         double c = double.Parse(Console.ReadLine());

         double discriminant = b * b - 4 * a * c;

         if (discriminant > 0)
         {
             double x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
             double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
             Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
         }
         else if (discriminant < 0)
         {
             Console.Write("No real roots");
         }
         else if (discriminant == 0)
         {
             Console.Write("x1 = x2 = {0}", -b / 2 * a);
         }
     }
 }

