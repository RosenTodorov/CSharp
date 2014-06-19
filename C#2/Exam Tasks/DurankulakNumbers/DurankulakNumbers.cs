using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class DurankulakNumbers
{
    static void Main()    
    {       
        List<string> numbers = new List<string>(168);        
        for (char i = 'A'; i <= 'Z'; i++)       
        {           
            numbers.Add(i.ToString());   
        }       
        for (char i = 'a'; i <= 'f'; i++)       
        {            
            for (char j = 'A'; j <= 'Z'; j++)      
            {                
                numbers.Add(i.ToString() + j.ToString());       
            }       
        }    
  
        string input = Console.ReadLine();       
        var builder = new StringBuilder();    
 
        List<int> convert = new List<int>();   
   
        for (int i = 0; i < input.Length; i++)       
        {         
            if (char.IsLower(input[i]))    
            {              
                builder.Append(input[i]);   
            }           
            else       
            {          
                builder.Append(input[i]);      
                //string str = builder.ToString();      
                int index = Array.IndexOf(numbers.ToArray(), builder.ToString());     
                convert.Add(index);            
                builder.Clear();         
            }       
        }      
        long result = 0;      
        int pow = 0;      
        for (int i = convert.Count - 1; i >= 0; i--)  
        {        
            result += convert[i] * (long)(Math.Pow(168, pow));   
            pow++;    
        }    
        Console.WriteLine(result); 
    }
}
   
        /* second way
         
    static void Main()
    {
        string[] durankulakDigits = GetDurankulakDigits();

        string durankulakNumber = Console.ReadLine(); // da si pro4etem durankulak nomera

        List<uint> decimalRepresentations = GetDecimalRepresentations(durankulakDigits, durankulakNumber);

        ulong decimalNumber = GetDecimalNumber(decimalRepresentations);
        Console.WriteLine(decimalNumber);
    }

    static ulong GetDecimalNumber(List<uint> decimalRepresentations)
    {
        ulong result = 0;
        for (int i = 0; i < decimalRepresentations.Count; i++)
        {
            result += decimalRepresentations[decimalRepresentations.Count - i - 1] * (ulong)Math.Pow(168, i);
        }

        return result;
    }

    static List<uint> GetDecimalRepresentations(string[] durankulakDigits, string durankulakNumber)
    {
        List<uint> decimalRepresentations = new List<uint>();
        char buffer = new char();
        foreach (char symbol in durankulakNumber)
        {
            if (symbol >= 'A' && symbol <= 'Z')
            {
                string durankulakDigit = null;
                uint decimalRepresentation = 0;
                if (buffer != default(char))
                {
                    durankulakDigit = string.Format("{0}{1}", buffer, symbol);
                    buffer = default(char);
                }
                else
                {
                    durankulakDigit = symbol.ToString();
                }

                decimalRepresentation = (uint)Array.IndexOf(durankulakDigits, durankulakDigit);
                decimalRepresentations.Add(decimalRepresentation);
            }
            else
            {
                buffer = symbol;
            }
        }

        return decimalRepresentations;
    }

    static string[] GetDurankulakDigits()
    {
        string[] durankulagDigits = new string[168];

        for (int i = 0; i < 168; i++)
        {
            if (i < 26) //tolkova sa na broi cifrite v angliiskata azbuka
            {
                // add durankulak digits
                durankulagDigits[i] = ((char)('A' + i)).ToString(); // tuk ne ni trqbva aski kodovete. 'A' ima int predstavqne i kato se sabere s i 6te dava int, a nie go slagame da e kato char i go stringosvame
            }
            else if (i < 2 * 26)
            {
                durankulagDigits[i] = "a" + durankulagDigits[i - 26];
            }
            else if (i < 3 * 26) //78
            {
                durankulagDigits[i] = "b" + durankulagDigits[i - 2 * 26];
            }
            else if (i < 4 * 26) //104
            {
                durankulagDigits[i] = "c" + durankulagDigits[i - 3 * 26];
            }
            else if (i < 5 * 26)
            {
                durankulagDigits[i] = "d" + durankulagDigits[i - 4 * 26];
            }
            else if (i < 6 * 26) //156 e nai-golqmoto do 168
            {
                durankulagDigits[i] = "e" + durankulagDigits[i - 5 * 26];
            }
            else
            {
                durankulagDigits[i] = "f" + durankulagDigits[i - 6 * 26];
            }
        }
        return durankulagDigits;
    }
} */






