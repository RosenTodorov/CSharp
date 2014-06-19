using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*Write a program that parses an URL address given and extracts from it the [protocol], [server] and [resource] elements.  
  For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:		
  [protocol] = "http"		[server] = "www.devbg.org"		[resource] = "/forum/index.php" */

namespace ParseURLAddress
{
    class ParseURLAddress
    {
             static string ReturnProtocol(StringBuilder sb, string address, int index)
             {
                 while (true)
                 {
                     if (address[index] != ':')
                     {
                         sb.Append(address[index]);
                     }
                     else
                     {
                         break;
                     }
                     index++;
                 }
                 string protocol = sb.ToString();
                 sb.Clear();

                 return protocol;
             }

             static void ReturnServerAndResource (StringBuilder sb, string address)
             {
                 int StartIndex = address.IndexOf(':') + 3;
                 int element = StartIndex;

                 for (int i = StartIndex; i < address.Length; i++)
                 {
                     element++;
                     if (address[i] != '/')
                         sb.Append(address[i]);
                     else
                         break;
                 }
                 string server = sb.ToString();
                 sb.Clear();
                 Console.WriteLine("[server] = \"{0}\"", server);

                 for (int i = element; i < address.Length; i++)
                 {
                     sb.Append(address[i]);
                 }
                 string resource = sb.ToString();
                 Console.WriteLine("[resource] = \"{0}\"", resource);		 
                 }
     
             static void Main()
             {
                 string URL = "http://www.devbg.org/forum/index.php";
                 int index = 0;

                 StringBuilder sb = new StringBuilder();
                 Console.WriteLine("[protocol] = \"{0}\"", ReturnProtocol(sb, URL, index));
                 ReturnServerAndResource(sb, URL);
             }
         }
     } 

  /*      // second way

        static void Main()
        {
            string url = "https://www.devbg.org/forum/index.php";

            Match protocol = Regex.Match(url, @"\b\w+");
            Console.WriteLine("[protocol] = \"{0}\"", protocol);

            url = Regex.Replace(url, protocol.ToString() + @"\W+", "");
            Match server = Regex.Match(url, @"\w*\W*\w+\W+\w+");
            Console.WriteLine("[server] = \"{0}\"", server);

            url = Regex.Replace(url, server.ToString(), "");
            Console.WriteLine("[resourse] = \"{0}\"", url);


        }
    }
} */