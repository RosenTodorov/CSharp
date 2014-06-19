using System;

class CirclePerimeterArea
    {
        static void Main()
        {
            Console.Write("Please put the value for the radius \'r\':");
            string radius = Console.ReadLine();
            double r = double.Parse(radius);

            double perimeter = 2 * r * Math.PI;
            double area = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("The perimeter is: {0:0.00}", perimeter);
            Console.WriteLine("The area is: {0:0.00}", area); 
        }
    }


