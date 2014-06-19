using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichanNumbers
{
    class KaspichanNumbers
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine()); //prasvame 4isloto 
            List<string> digits = new List<string>(); //palnim tozi list sas digits

            for (char i = 'A'; i <= 'Z'; i++) //za golemite bukvi "A"
            {
                digits.Add(i.ToString()); //stringosvame go za6toto lista koito palnim e string
            }

            for (char i = 'a'; i <= 'i'; i++) //za malki i golemi bukvi "aB"
            {
                for (char j = 'A'; j <= 'Z'; j++)
                {
                    digits.Add(i.ToString() + j.ToString());
                }
            }
                /* foreach (var item in digits)
                 {
                     Console.Write(item + " ");
                 }  za proverka */

                string result = ""; // sazdavame promenliva kadeto dobavqme tova koeto sme polu4ili do sega plius resulta

                if (number == 0)
                {
                    Console.WriteLine("A"); 
                }
                while (number != 0)
                {
                    result = digits[(int)(number % 256)] + result; //number e indeksa na elementa digits na tazi pozicia
                    number = number / 256;
                }
                Console.WriteLine(result);
            }
        }
    }





