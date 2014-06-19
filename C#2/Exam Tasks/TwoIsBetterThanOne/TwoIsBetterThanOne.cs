namespace TwoIsBetterThanOne
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static bool IsPalindrom(long number)
        {
            string num = number.ToString();
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        static int FindLuckyNumbers(long lowerBound, long upperBound)
        {
            long max = upperBound;
            int left = 0;
            var numbers = new List<long> { 3, 5 };

            int count = 0;
            while (left < numbers.Count)
            {
                int right = numbers.Count;
                for (int i = left; i < right; i++)
                {
                    if (numbers[i] < max)
                    {
                        numbers.Add((numbers[i] * 10) + 3); //ot 3 stava na 30 + 3 = 33 ili 30 + 5 = 35 
                        numbers.Add((numbers[i] * 10) + 5);
                    }
                }
                left = right; // nakraq stava lqvata strana e ravna na dqsnata
            }

            foreach (var num in numbers)
            {
                if (num >= lowerBound && num <= upperBound && IsPalindrom(num))
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            long lowerBound = long.Parse(tokens[0]); //parvo toi se vkarva ot konzolata
            long upperBound = long.Parse(tokens[1]);

            int count = FindLuckyNumbers(lowerBound, upperBound);

            string inputList = Console.ReadLine();
            string[] listTokens = inputList.Split(',');
            List<int> numbers = new List<int>();
            for (int i = 0; i < listTokens.Length; i++)
            {
                numbers.Add(int.Parse(listTokens[i]));
            }
            int percent = int.Parse(Console.ReadLine());
            int answerSecondTask = FindAnswerSecondTask(numbers, percent);

            Console.WriteLine(count);
            Console.WriteLine(answerSecondTask);
        }

        private static int FindAnswerSecondTask(List<int> numbers, int percent)
        {
            numbers.Sort(); // parvo sortirvame lista
            for (int i = 0; i < numbers.Count; i++)
            {
                int countSmaller = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] >= numbers[j]) //za da izvadim po-malkite 4isla
                    {
                        countSmaller++;
                    }
                }

                if (countSmaller >= (numbers.Count * (percent / 100.0))) //za6to iskat po uslovie parvoto 4islo ot tezi koito sa po-malki sled procenta
                {
                    return numbers[i];
                }
            }

            return numbers[numbers.Count - 1]; // ako ne sme namerili takova 4islo po-malko ot procentite vra6tame nego poslednoto
        }
    }
}








