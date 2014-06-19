using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers:");
        int one = Int32.Parse(Console.ReadLine());
        int two = Int32.Parse(Console.ReadLine());
        int three = Int32.Parse(Console.ReadLine());
        int four = Int32.Parse(Console.ReadLine());
        int five = Int32.Parse(Console.ReadLine());

        int greatestNumber = 0;

        if (one == two && two == three && three == four && four == five)
        {
            Console.WriteLine("The numbers are equal!");
        }
        if (greatestNumber < one)
        {
            greatestNumber = one;
        }
        if (greatestNumber < two)
        {
            greatestNumber = two;
        }
        if (greatestNumber < three)
        {
            greatestNumber = three;
        }
        if (greatestNumber < four)
        {
            greatestNumber = four;
        }
        if (greatestNumber < five)
        {
            greatestNumber = five;
        }
        Console.WriteLine("The greatest number is: {0}", greatestNumber);
    }
}

        //Second way          
        // int biggest = Math.Max(Math.Max((Math.Max(one, two)), Math.Max(three, four)), five);        
        // Console.WriteLine("The greatest number, chosen by the second way is {0}", biggest);



