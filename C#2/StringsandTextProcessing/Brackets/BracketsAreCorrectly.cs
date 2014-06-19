using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to check if in a given expression the brackets are put correctly. Example of correct expression: ((a+b)/5-d).Example of incorrect expression: )(a+b)).

namespace Brackets
{
    class BracketsAreCorrectly
    {
        static void Main()
        {
            Console.WriteLine("Enter some expression: ");
            //string expression = ")(a+b))";
            string expression = Console.ReadLine();

            int leftBraket = 0;
            int rightBraket = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    leftBraket++;
                }
                if (expression[i] == ')')
                {
                    rightBraket++;
                }
            }

            if (expression.IndexOf('(', 0) > expression.IndexOf(')') || expression.IndexOf('(') == -1 || leftBraket != rightBraket) //broq na levite i desnite skobi trqbva da e raven ina4e vse 6te ima nqkoi otvorena ili zatvorena v pove4e !!!
            {
                Console.WriteLine("Error in expression!");
            }
            else
            {
                Console.WriteLine("Expression is correct! ");
            }
        }
    }
}
 