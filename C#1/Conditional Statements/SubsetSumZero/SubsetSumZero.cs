using System;


 class SubsetSumZero
 {
     static void Main()
     {
         Console.WriteLine("Enter five numbers.");
         Console.Write("1st: ");
         int a = int.Parse(Console.ReadLine());
         Console.Write("2nd: ");
         int b = int.Parse(Console.ReadLine());
         Console.Write("3rd: ");
         int c = int.Parse(Console.ReadLine());
         Console.Write("4th: ");
         int d = int.Parse(Console.ReadLine());
         Console.Write("5th: ");
         int e = int.Parse(Console.ReadLine());

         if (a + b + c + d + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
         }

         //4 digits
         if (b + c + d + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
         }
         if (a + c + d + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
         }
         if (a + b + d + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
         }
         if (a + b + c + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
         }
         if (a + b + c + d == 0)
         {
             Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
         }

         //3 digits
         if (a + b + c == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
         }
         if (b + c + d == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
         }
         if (c + d + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
         }
         if (e + b + c == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", e, b, c);
         }
         if (a + c + d == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
         }
         if (a + d + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
         }
         if (b + d + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
         }
         if (b + c + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
         }
         if (a + c + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
         }
         if (a + b + e == 0)
         {
             Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
         }

         //2 digits
         if (a + b == 0)
         {
             Console.WriteLine("{0} + {1} = 0", a, b);
         }
         if (a + c == 0)
         {
             Console.WriteLine("{0} + {1} = 0", a, c);
         }
         if (a + d == 0)
         {
             Console.WriteLine("{0} + {1} = 0", a, d);
         }
         if (a + e == 0)
         {
             Console.WriteLine("{0} + {1} = 0", a, e);
         }
         if (b + c == 0)
         {
             Console.WriteLine("{0} + {1} = 0", b, c);
         }
         if (b + d == 0)
         {
             Console.WriteLine("{0} + {1} = 0", b, d);
         }
         if (b + e == 0)
         {
             Console.WriteLine("{0} + {1} = 0", b, e);
         }
         if (c + d == 0)
         {
             Console.WriteLine("{0} + {1} = 0", c, d);
         }
         if (c + e == 0)
         {
             Console.WriteLine("{0} + {1} = 0", c, e);
         }
         if (d + e == 0)
         {
             Console.WriteLine("{0} + {1} = 0", d, e);
         }
         else
         {
             Console.WriteLine("No subset");
         }
     }
 }
            
