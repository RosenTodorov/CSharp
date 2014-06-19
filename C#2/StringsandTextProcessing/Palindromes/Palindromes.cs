using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string text = "Sos, bob ili potop, ABBA slusham az!";
            char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
            string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in splitted)
            {
                bool isPalindrome = true;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome && word.Length > 1)
                {
                    Console.WriteLine(word);
                }
            }

            /* second way:
             
            string text = "Sos, bob ili potop, ABBA slusham az!";                      
            string[] words = text.Split(' ', ',', '.');        
            string element = "";      
            StringBuilder firstPart = new StringBuilder();   
            StringBuilder secondPart = new StringBuilder();      
            for (int i = 0; i < words.Length; i++)       
            {           
                element = words[i];      
                string firstHalf = "";      
                string secondHalf = "";           
                if (element.Length % 2 == 0 && element!= "")   
                {             
                    for (int j = 0; j < element.Length / 2; j++)     
                    {                 
                        firstPart.Append(element[j]);         
                    }       
                    for (int j = element.Length - 1; j >= element.Length / 2; j--)   
                    {             
                        secondPart.Append(element[j]);             
                    }           
                    firstHalf = firstPart.ToString();      
                    secondHalf = secondPart.ToString();    
                    firstPart.Clear();             
                    secondPart.Clear();           
                    int compare = string.Compare(firstHalf, secondHalf, StringComparison.InvariantCultureIgnoreCase);      
                    if (compare == 0)         
                    {                
                        Console.WriteLine(element);    
                    }          
                }          
                else if(element.Length % 2 != 0 && element!= "") 
                {             
                    for (int j = 0; j < element.Length / 2; j++)     
                    {                  
                        firstPart.Append(element[j]);       
                    }            
                    for (int j = element.Length - 1; j >= element.Length / 2 + 1; j--)   
                    {        
                        secondPart.Append(element[j]);         
                    }            
                    firstHalf = firstPart.ToString();      
                    secondHalf = secondPart.ToString();    
                    firstPart.Clear();               
                    secondPart.Clear();            
                    int compare = string.Compare(firstHalf, secondHalf, StringComparison.InvariantCultureIgnoreCase);    
                    if (compare == 0)      
                    {               
                        Console.WriteLine(element);  
                    }        
                }      
            }   */
        }
    }
}
        


 
                











			
			 
			





