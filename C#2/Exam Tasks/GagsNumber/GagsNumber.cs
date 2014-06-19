using System;
using System.Numerics;

class GagsNumber
{
    static string ConvertGagStringToNumber(string digit)
    {
        string result = "NO"; //toest ako v tozi switch ni6to nenameri, koeto da savpada s na6ite cifri da varne "NO"

        switch (digit) // tuka cifrite ni sa v deveti4na broina sistema !
        {
            case "-!": result = "0"; break;
            case "**": result = "1"; break;
            case "!!!": result = "2"; break;
            case "&&": result = "3"; break;
            case "&-": result = "4"; break;
            case "!-": result = "5"; break;
            case "*!!!": result = "6"; break;
            case "&*!": result = "7"; break;
            case "!!**!-": result = "8"; break;
            default:
                break;
        }

        return result;
    }

    static BigInteger PowerOfNine(int power) //sazdavame go vmesto Math.Pow za6toto se gubi to4nost pri nego 
    {
        BigInteger result = 1;

        for (int i = 0; i < power; i++)
        {
            result *= 9;
        }

        return result;
    }

    static void Main()
    {
        string input = Console.ReadLine();

        string partialInput = string.Empty; // 4asti4no proverqvane na stringa i e ravno na empty, za6toto po4vame ot ni6toto
        string nineSystemNumber = "";

        for (int i = 0; i < input.Length; i++)
        {
            partialInput += input[i]; //teku6tia simvol go dobavqme

            string currentDigit =
                ConvertGagStringToNumber(partialInput);

            if (currentDigit != "NO") //ako ni e varnala nqkakva cifra
            {
                nineSystemNumber += currentDigit;
                partialInput = ""; //sled kato bade dobavena cifrata v 9-ti4na sistema za4istvame stringa, za da moje pri sledva6to tarsene na stringa da ne se vliqe ot prednia nameren
            }
        }

        // Console.WriteLine(nineSystemNumber);

        BigInteger result = 0;

        for (int i = 0; i < nineSystemNumber.Length; i++)
        {
            BigInteger digit =
                BigInteger.Parse(nineSystemNumber[i].ToString());

            result += digit * PowerOfNine(nineSystemNumber.Length - i - 1);
        }

        Console.WriteLine(result);
    }
}

