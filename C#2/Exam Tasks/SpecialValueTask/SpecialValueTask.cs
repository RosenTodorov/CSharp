using System;

class SpecialValue
{ //kak da zapalnim redovete
    static int[][] ReadData(int[][] field) // tuk mu se podavamasiva field koito trqbva da bade zapalnen
    {
        for (int i = 0; i < field.GetLength(0); i++) //GetLength za6toto e dvumeren, t.e za vseki red trqbva da pro4etem na6ite 4isla
        {
            string[] currentLine =
                Console.ReadLine()
                .Split(new char[] { ' ', ',' }, //splitva po interval i zapetaq 
                StringSplitOptions.RemoveEmptyEntries);

            field[i] = new int[currentLine.Length];

            for (int l = 0; l < currentLine.Length; l++) // da popalnem kolonite l
            {
                field[i][l] = int.Parse(currentLine[l]);
            }
        }

        return field;
    }

    static long FindCurrentSpecialValue
        (int[][] field, int column, bool[][] used)
    {
        long result = 0;
        int currentRow = 0;

        while (true)
        {
            result++;

            if (used[currentRow][column]) //ako e poseteno 4isloto
            {
                return long.MinValue;
            }

            if (field[currentRow][column] < 0)
            {
                result -= field[currentRow][column]; //dobavq se absoliutnata stoinost na otricatelnoto 4islo (moje i s Math.Abs da se polzva ili Math.Abs(field[currentRow][column];

                return result;
            }

            int nextColumn = field[currentRow][column]; // 6tom ne sa izpalneni dvete gorni uslovia (ne e poseteno 4isloto ili ne e otricatelno)
            used[currentRow][column] = true; // ve4e e poseteno
            column = nextColumn;

            currentRow++;

            if (currentRow == field.GetLength(0))// ako e stignal do kraq po4va ot na4alo 0-lev red
            {
                currentRow = 0;
            }
        }
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[][] field = new int[N][]; // iskame N na broi redove, no neznaem kolko sa kolonite zatova go ostavqme prazno tam

        ReadData(field);

        bool[][] used = new bool[N][];

        for (int i = 0; i < N; i++)
        {
            used[i] = new bool[field[i].Length];
        }

        long max = long.MinValue;

        for (int i = 0; i < field[0].Length; i++)
        {
            long specialValue =
                FindCurrentSpecialValue(field, i, used);

            if (max < specialValue)
            {
                max = specialValue;
            }
        }

        Console.WriteLine(max);
    }
}