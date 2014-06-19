using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*Write a program for extracting all email addresses from given text. 
 All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string text = "Ala bala portokala jijibiji@abv.bg, telerik academy tva onova yohoho@dvebutilki.rom. Loren ipsum,somemail@gmail.com, and yahoo_s@mail.bg.";


              MatchCollection collector = Regex.Matches(text, @"\w+@\w+\.\w+"); //търси за дума, следвана от @, след това нова дума, точка и пак друга дума.

              foreach (var item in collector)
              {
                  Console.WriteLine(item);
              }
          }
      }
  } 
            /*second way       
            int index = 0;
            StringBuilder sb = new StringBuilder();
            while (index < text.Length)
            {
                int start = 0;
                int end = 0;
                int dotCount = 0;
                if (text[index] == '@')
                {
                    for (int i = index; i >= 0; i--)
                    {
                        if (text[i] == ' ' || text[i] == ',')
                        {
                            start = i + 1;
                            break;
                        }
                    }
                    for (int i = index; i < text.Length; i++)
                    {
                        if ((text[i] == ',' || text[i] == '.' || text[i] == ' ') && dotCount > 0)
                        {
                            end = i - 1;
                            break;
                        }
                        if (text[i] == '.')
                        {
                            dotCount++;
                        }
                    }
                    for (int i = start; i <= end; i++)
                    {
                        sb.Append(text[i]);
                    }
                    Console.WriteLine(sb.ToString());
                    sb.Clear();
                }
                index++;
            }
        }
    }
} */
        