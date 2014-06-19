// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

class ExtractWithoutTags
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"../../someXML.xml"))
        {
            string text = reader.ReadToEnd();
            text = Regex.Replace(text, "\r", "");
            text = Regex.Replace(text, "\n", "");

            string regex = @"[>]\s*(?<text>\w*.)\s*[<]";

            MatchCollection matches = Regex.Matches(text, regex);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups["text"]);
            }
        }
    }
}
