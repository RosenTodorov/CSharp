using System;

class ChoiceForInput
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for int, 2 for double, and 3 for string");
        sbyte choice = sbyte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: 
                int inputInt = Int32.Parse(Console.ReadLine()); 
                Console.WriteLine(inputInt + 1); 
                break;
            case 2: 
                double inputDouble = Double.Parse(Console.ReadLine()); 
                Console.WriteLine(inputDouble + 1); 
                break;
            case 3: 
                string inputString = Console.ReadLine(); 
                Console.WriteLine(inputString + "*"); 
                break;
            default: 
                Console.WriteLine("Please choose a valid number!"); 
                break;
        }
    }
}

