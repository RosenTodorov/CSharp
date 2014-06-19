using System;

/* Write methods that calculate the surface of a triangle by given: 
   Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math. */

namespace TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("First option: Please input side and altitude: ");
            double side = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());

            Console.WriteLine("Second option: Please input three sides: ");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            Console.WriteLine("Third option: Please input two sides and angle in degrees: ");
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());
            double degrees = double.Parse(Console.ReadLine());

            Console.WriteLine("First option: Surface is: {0}", SurfaceBySideAndAltitude(side, altitude));
            Console.WriteLine("Second option: Surface is: {0}", SurfaceByThreeSides(sideA, sideB, sideC));
            Console.WriteLine("Third option: Surface is: {0}", SurfaceByTwoSidesAndAngle(firstSide, secondSide, degrees));
        }

        static double SurfaceBySideAndAltitude(double side, double altitude)
        {
            double surface = 0.5 * side * altitude;
            return surface;
        }

        static double SurfaceByThreeSides(double sideA, double sideB, double sideC)
        {
            double halfPerimeter = 0.5 * (sideA + sideB + sideC);
            double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return surface;
        }

        static double SurfaceByTwoSidesAndAngle(double firstSide, double secondSide, double degrees)
        {
            double surface = 0.5 * firstSide * secondSide * Math.Sin(ConvertDegreesInRadians(degrees));
            return surface;
        }

        static double ConvertDegreesInRadians(double degrees)
        {
            double radians = Math.PI * degrees / 180.0;
            return radians;
        }
    }
}





