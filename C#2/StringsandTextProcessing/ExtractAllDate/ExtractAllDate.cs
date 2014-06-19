using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExtractAllDate
{
    class ExtractAllDate
    {
        static void Main()
        {
            string text = "We are going to a picnic om 12.04.2014 and 23.03.2014, 30.12.2013 !!!";
            DateTime date = new DateTime();

            MatchCollection results = Regex.Matches(text, @"\b[0-9]{1,2}.[0-9]{1,2}.[2,4]"); // \b - Begin the match at a word boundary; The match must occur on a boundary between a \w (alphanumeric) and a \W (nonalphanumeric) character.

            for (int i = 0; i < results.Count; i++)
            {

                if (DateTime.TryParse(results[i].ToString(), out date))
                {
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));

                }
            }
        }
    }
}

