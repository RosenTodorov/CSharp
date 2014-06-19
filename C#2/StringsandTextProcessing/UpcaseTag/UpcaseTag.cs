using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You are given a text. Write a program that changes the text in all regions surrounded by the 
* tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example: */

namespace UpcaseTag
{
    class UpcaseTag
    {
        static void Main()
        {
            string str = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            // 1. Създавам си две променливи startIndex и endIndex, като това е диапазона в който е текста който трябва да направя с главни букви, един вид м/у таговете
            int startIndex = 0;
            int endIndex = 0;
            Console.WriteLine(str);

            //Пускам for цикъл до str.Length - 8, (минус осем, защото да не излезе от stringa)
            for (int i = 0; i < str.Length - 8; i++)
            {
                //След това започвам да търся substring(парче от стринга) който отговаря на <upcase>.
                if (str.Substring(i, 8) == "<upcase>")
                {
                    // Щом намеря такова го записвам в startIndex индекса на който го е намерил и добавям дължината на <upcase> за да запиша индекса точно след него. От където ще започна да правя текста с главни букви. Също така за да не обхождам и проверявам следващите 8 индекса, дали отговарят на търсения substring, прескачам там където ми е startIndex-a, като присвоявам на i=startIndex (лека оптимизация)
                    startIndex = i + 8;
                    i = startIndex;
                }
                //Аналогично като т.3 с разликата че тук тага вече е с дължина 9 символа
                if (str.Substring(i, 9) == "</upcase>")
                {
                    //Присвоявам на endIndex-a, индекса на който съм го октрил тага </upcase>.
                    endIndex = i;
                    int length = endIndex - startIndex;
                    //След това създвам нова променлива upperStr на която и присвоявам - текста в диапазона който искам да е с главни букви, като го правя с главни без значение какви са.
                    string upperStr = str.Substring(startIndex, length).ToUpper();
                    //Console.WriteLine(upperStr);
                    //Махам в str текста в диапазона от startIndex до endIndex.
                    str = str.Remove(startIndex, length);
                    //Console.WriteLine(str);
                    //Insert в str на позиция startIndex upperStr. Вече буквите са главни остава само да махна таговете..
                    str = str.Insert(startIndex, upperStr);
                    //Console.WriteLine(str);
                    //Махам първия таг, след това втория таг като използвам startIndex, endIndex , за тяхното местоположение.
                    str = str.Remove(startIndex - 8, 8);
                    str = str.Remove(endIndex - 8, 9);
                }
            }
            Console.WriteLine(str);
        }
    }
}
