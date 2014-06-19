using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace example
{
    class Program
    {
        static void Main()
        {
            if (File.Exists("input.txt"))
            {
                Console.SetIn(new StreamReader("input.txt"));
            }
            int[] dims = GetThreeNumbresFromConsole(); //razmerite na kuba sa parvite 4isla, koito 6te 4etem ot konzolata
            int[] pos = GetThreeNumbresFromConsole(); //na4alnite pozicii
            int[] vect = GetThreeNumbresFromConsole(); //poso4enite vektori

            bool[, ,] visited = new bool[dims[0] + 1, dims[1] + 1, dims[2] + 1]; //masiv ot tri izmerenia kato go uveli4avame s 1-ca

            while (true)
            {
                visited[pos[0], pos[1], pos[2]] = true;
                int[] newPos = new int[3];
                // pos: (2, 2, 2)
                // vect: (1, 0, -1)
                // newPos: (3, 2, 1)
                for (int i = 0; i < 3; i++)
                {
                    newPos[i] = pos[i] + vect[i];
                }

                if (visited[newPos[0], newPos[1], newPos[2]] || // ako e true zna4i sme svar6ili
                    HowManyIndexesAreLimit(newPos, dims) >= 2)  // ako e ravno na dve zna4i sme stignali rab ili ako e ravno na 3 sme stignali to varha zatova e po-golqmo
                {
                    // next position is visited
                    Console.WriteLine("{0} {1} {2}", pos[0], pos[1], pos[2]);
                    return;
                }

                if (HowManyIndexesAreLimit(newPos, dims) == 1)
                {
                    // we''ve hit a wall - zna4i trqbva da obarnem la4a
                    ReverseComponent(newPos, vect, dims);
                }
                for (int i = 0; i < 3; i++)
                {
                    pos[i] = newPos[i];
                }
            }
        }
        static void ReverseComponent(int[] newPos, int[] vect, int[] dims)
        {
            for (int i = 0; i < 3; i++)
            {
                if (newPos[i] == 1 && vect[i] == -1) //pri sledva6tia hot 6te stane nula poziciata i 6te izleze izvan kuba zatova obra6tame poziciata ili la4a
                {
                    vect[i] *= -1;
                }
                else if (newPos[i] == dims[i] && vect[i] == 1) //ako komponenta e raven na razmera na kuba i komponenta na vektora e polojitelen to vektora ni kara da izlizame ot polojitelnata posoka i v tozi slu4ai pak izlizame ot vektora
                {
                    vect[i] *= -1;
                }
            }
        }

        static int HowManyIndexesAreLimit(int[] pos, int[] dims) // kolko ot indeksite sa na kraq na kuba - podavame poziciata za koqto pitame i razmerite na kuba
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (pos[i] == 1 || pos[i] == dims[i])
                    count += 1;
            }
            return count;
        }

        static int[] GetThreeNumbresFromConsole()
        {
            string input = Console.ReadLine();
            string[] split = input.Split(' ');
            int[] array = new int[3];
            for (int i = 0; i < 3; i++)
            {
                array[i] = int.Parse(split[i]);
            }
            return array;
            // return split.Select(s => int.Parse(s)).ToArray();

        }
    }
}
