using System;

// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class BinaryRepresentationOfShort
{    
    static void Main() 
    {     
        Console.WriteLine("Input number ({0} <= number <= {1})", short.MinValue, short.MaxValue);     
        //short number = short.Parse(Console.ReadLine());    
        //string result = "";   
        //for (int i = 0; i < 15; i++)     
        //{       
        //    int bit = ((number >> i) & 1);      
        //    result = bit + result;   
        //}    
        //Console.WriteLine(result);   
        string result = Convert.ToString(short.Parse(Console.ReadLine()), 2).PadLeft(16, '0');    
        Console.WriteLine(result);    
    }
}
