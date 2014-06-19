using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoroTheRabbit
{
    class JoroTheRabbit
    {
        static void Main()
        {
            int[] numbers;

            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries); //!

            numbers = new int[inputNumbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(inputNumbers[i]);
            }

            int bestPath = 0; // tarsim nai-dobrata pateka

            for (int startIndex = 0; startIndex < numbers.Length; startIndex++) //tam kadeto zapo4vame kato po4va ot indeks nula i zapo4va da se varti
            {
                for (int step = 0; step < numbers.Length; step++) //stapkite na zaqka do daljinata na masiva, kato po4va ot edinica
                {
                    int index = startIndex;
                    int currentPath = 1;
                    int next = (index + step); // za da vidim na koi ideks ili pozicia e ako e prehvarlilo
                    if (next >= numbers.Length)
                    {
                        next = next - numbers.Length;
                    }

                    while (numbers[index] < numbers[next])
                    {
                        currentPath++;
                        index = next;
                        next = (index + step) % numbers.Length;
                    }

                    if (bestPath < currentPath)
                    {
                        bestPath = currentPath;
                    }
                }
            }
            Console.WriteLine(bestPath);
        }
    }
}

                
      

















