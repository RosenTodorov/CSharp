using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam_Tasks
{
    class OneTaskIsNotEnough
    {
        static void Main()
        {
            if (File.Exists("Input.txt"))
            {
                Console.SetIn(new StreamReader("Input.txt"));
            }

            Console.WriteLine(Task1());

            Console.WriteLine(Task2());

            Console.WriteLine(Task2());
        }

        static int Task1()
        {
            int countOff = int.Parse(Console.ReadLine()); // 4etem borqt lampi s koito 6te rabotim v konzolata i pravim dva masiva
            var turnOnNow = new bool[countOff + 1]; // tuk pazim broq na lampite koito sa vkliu4eni kato broim ot edno (parva lampa)
            var lampsStillOff = new int[countOff + 1]; // na6ia spisak s nevkliu4eni lampi. countOff + 1 e za6toto da po4va ot parva pozicia ili lampa edno a ne ot nuleva indeks v masiva

            int lastLamp = 0;

            for (int i = 1; i <= countOff; i++)
            {
                lampsStillOff[i] = 1;
            }

            int jump = 1;
            while (countOff > 0)
            {
                jump++; //slagame kakva e goleminata na skoka na vseki hod

                Array.Clear(turnOnNow, 1, countOff); //palnim masiva s nuli turnOnNow ot pozicia edno do broq na countOff

                int turnOnNowCount = 0;
                for (int i = 1; i <= countOff; i += jump)
                {
                    turnOnNow[i] = true; //palnim masiva s vkliu4enite lampi sprqmo stapkata jump, predstavlqva indeksite na lampite koito 6te vkliu4im
                }
                int newCountOff = 0;

                for (int i = 1; i <= countOff; i++)
                {
                    if (!turnOnNow[i])// da gi mahnem ot na6ia spisak s izkliu4eni lampi
                    {
                        newCountOff++;
                        lampsStillOff[newCountOff] = lampsStillOff[i];
                        lastLamp = lampsStillOff[i]; //vseki pat 6te se zapazva tuk ili 6te zapazvame poslednata izkliu4ena lampa
                    }
                }

                countOff = newCountOff;
            }
            return lastLamp;
        }

        static string Task2()
        {
            string commands = Console.ReadLine();

            int[] dx = { 1, 0, -1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            int x = 0;
            int y = 0;
            int orientation = 0;

            for (int i = 0; i < 4; i++)
            {
                foreach (var command in commands)
                {
                    if (command == 'S')
                    {
                        x += dx[orientation];
                        y += dy[orientation];
                    }
                    else if (command == 'L') //ako komadata e L namalqme indeksa s -1 i go slagame mejdu nula i 4ri
                    {
                        orientation -= 1;
                        orientation += 4;
                        orientation %= 4; //s modul osigurqvame da e v tozi modul mejdu 0 i 4ri (ili 9 i x)
                    }
                    else if (command == 'R') //ako podavame komanda za zavartane na dqsno uveli4avame indeksa s edno i osigurqvame da e mejdu 0 i 4ri s modul
                    {
                        orientation += 1;
                        orientation %= 4;
                    }
                }
            }
            // dali se vra6tame na sa6toto mqsto 
            if (x == 0 && y == 0)
            {
                return "bounded";
            }
            else
            {
                return "unbounded"; // - безкраен, неограничен 
            }
        }
    }
}



    








          

    
    
        




			

			 
			

			




			













