using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyDwarf
{
    class GreedyDwarf
    {
        private static long ProccessPattern(int[] valley)
        {
            string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] pattern = new int[rawNumbers.Length];

            for (int i = 0; i < pattern.Length; i++)
            {
                pattern[i] = int.Parse(rawNumbers[i]);
            } //ve4e si imame samia pattern i dolu dolinata

            bool[] visited = new bool[valley.Length]; //sazdavame edna buleva promenliva, koqto 6te ni pokazva dali poziciata e bila posetena ot pattern-a (patekata)
            long coinSum = 0;
            coinSum += valley[0]; //dobavqme mu nulevata pozicia za6toto djudjeto vinagi po4va ot parvata pozicia na dolinata
            visited[0] = true; // poneje ot gornoto nie vinagi stapvame na parvia element kato mu dobavihme predvaritelno parvata pozicia

            //trqbva da znaem teku6tata ni pozicia
            int currentPosition = 0;

            while (true)
            {
                for (int i = 0; i < pattern.Length; i++)
                {
                    int nextMove = currentPosition + pattern[i]; // e ravno na teku6tata pozicia plius elementa ot patterna na koito sme v momenta

                    if (nextMove >= 0 && nextMove < valley.Length && !visited[nextMove])
                    {
                        coinSum += valley[nextMove];
                        visited[nextMove] = true;
                        currentPosition = nextMove;
                    }
                    else
                    {
                        return coinSum;
                    }
                }
            }
        }

        static void Main()
        {
            // vzemame surovite 4isla i gi splitvame
            string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] valleyNumbers = new int[rawNumbers.Length]; // vzemame ve4e splitnatite 4isla s daljina na surovite ni 4isla

            for (int i = 0; i < valleyNumbers.Length; i++)
            {
                valleyNumbers[i] = int.Parse(rawNumbers[i]); //parsnata ni stoinost ot surovite 4isla koito sme prieli ot konzolata         
            } // ve4e priehme dolinata i neinite 4isla

            int numberOfPatterns = int.Parse(Console.ReadLine()); //priemame ot konzolata 4isloto
            long bestSum = long.MinValue; //za6toto moje da imame samo otricatelni 4isla i da ne priema otricatelno za nai-dobrata ni suma

            for (int i = 0; i < numberOfPatterns; i++) //priemaneto na paternite redovete koito sa razdeleni pak ot zapetaq i space
            {
                long sum = ProccessPattern(valleyNumbers); //tuk pazim nai-dobroto 4islo ot rezultatite na razli4nite patterni

                if (sum > bestSum)
                {
                    bestSum = sum;
                }
            }
            Console.WriteLine(bestSum);
            }
        }
    }


























