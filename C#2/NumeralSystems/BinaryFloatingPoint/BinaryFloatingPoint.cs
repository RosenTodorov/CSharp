using System;

//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

class BinaryFloatingPoint
{
    static void Main()
    {
        Console.Write("Input a floating point number: ");
        double number = double.Parse(Console.ReadLine());
        string result = "";
        long doubleToBinary = BitConverter.DoubleToInt64Bits(number);

        for (int i = 0; i < 64; i++)
        {
            long bit = ((doubleToBinary >> i) & 1);
            result = bit + result;
        }
        Console.WriteLine(result);
    }
}
