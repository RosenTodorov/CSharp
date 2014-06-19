using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that reverses the words in given sentence.*/

namespace ReverseWordsInSentance
{
    /* class ReverseWordsInSentance
     {
         static void Main()
         {
             string text = "C# is not C++, not PHP and not Delphi!"; 

             string[] words = text.Split(' ');
             Array.Reverse(words);

             Console.WriteLine(string.Join(" ", words));
         }
     }
 } */
    class ReverseWordInSentence
    {
        static void Main()
        {
            string str = "C# is not C++, not, PHP .and not Delphi! Test 1, 2,3.";
            string[] strWords = str.Split(new char[] { '!', '.', ',', ' ', }, StringSplitOptions.RemoveEmptyEntries);
            string[] signs = str.Split(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
                                                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')', '(',
                                                '*', '/', '=', '~', '`' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(strWords);
            StringBuilder strWordsReversed = new StringBuilder();

            for (int i = 0; i < signs.Length; i++)
            {
                strWordsReversed.Append(strWords[i]);
                strWordsReversed.Append(signs[i]);
            }
            Console.WriteLine(strWordsReversed.ToString());
        }
    }
}
