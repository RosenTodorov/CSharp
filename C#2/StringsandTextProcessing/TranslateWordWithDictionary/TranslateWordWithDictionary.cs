using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*A dictionary is stored as a sequence of text lines containing words and their explanations. 
  Write a program that enters a word and translates it by using the dictionary. */

namespace TranslateWordWithDictionary
{
    /* class TranslateWordWithDictionary
     {
         static void Main()
         {
             var sampleDictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
    {".NET"," - platform for applications from Microsoft"}, 
    {"CLR"," - managed execution environment for .NET"}, 
    {"namespace"," - hierarchical - organization of classes"}
         };
             Console.Write("Please put your word: ");
             string wordTosearch = Console.ReadLine();

             try
             {
                 Console.WriteLine("{0} {1}", wordTosearch, sampleDictionary[wordTosearch.ToLowerInvariant()]);
             }
             catch (KeyNotFoundException)
             {
                 Console.WriteLine("The word '{0}' cannot be found in the dictionary!", wordTosearch);
             }
         }
     }
 } */

    class Dictionary
    {
        static void Main()
        {
            string[] dictionary = { ".NET - platform for applications from Microsoft",
                                      "CLR - managed execution environment for .NET", 
                                      "namespace - hierarchical - organization of classes" };
            string search = ".NET";
            Console.WriteLine("Search for: {0}", search);
            bool resultAvailable = false;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i].IndexOf(search, StringComparison.InvariantCultureIgnoreCase) != -1)
                {
                    resultAvailable = true;
                    for (int j = dictionary[i].IndexOf(search) + search.Length + 3; j < dictionary[i].Length; j++)
                    {
                        sb.Append(dictionary[i][j]);
                    }
                    break;
                }
            }
            if (resultAvailable)
            {
                string result = sb.ToString();
                result = result.TrimStart(' ');
                Console.WriteLine("result: \"{0}\"", result);
            }
            else
            {
                Console.WriteLine("Can't find result!");
            }
        }
    }
}




     
