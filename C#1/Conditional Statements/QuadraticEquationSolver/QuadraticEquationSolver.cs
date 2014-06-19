using System;

class QuadraticEquationSolver
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients a,b and c of a quadratic equation");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("The quadratic equation is: {0}*X^2 + {1}*X + {2} = 0", a, b, c);
        double discriminant = ((b * b) + (4 * a * c));
        Console.WriteLine("The discriminant is {0}", discriminant);

        if (a != 0)
        {
            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots");
            }
            else
            {
                if (discriminant == 0)
                {
                    decimal oneRoot = ((b / (2 * a)) * (-1));
                    Console.WriteLine("There is one real root : {0}", oneRoot);
                }
                else if (discriminant > 0)
                {
                    double firstRoot = (((-1) * b) + Math.Sqrt(discriminant)) / (2 * a);
                    double secondRoot = (((-1) * b) - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("There are two roots: {0} and {1}", firstRoot, secondRoot);
                }
            }
        }
        if (a == 0)
        {
            decimal oneRoot = -c / b;
            Console.WriteLine("There is one real root : {0}", oneRoot);
        }
    }
}

        


