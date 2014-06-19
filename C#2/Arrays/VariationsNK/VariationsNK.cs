using System;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
//Example: N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

namespace VariationsNK
{
    class VariationsNK
    {
        static void VariationsGen(int[] array, int index, int N)
        {
            if (array.Length == index)
            {
                PrintVar(array);
            }
            else
            {
                for (int i = 1; i < N + 1; i++)
                {
                    array[index] = i;
                    VariationsGen(array, index + 1, N);
                }
            }
        }
        static void PrintVar(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            int N = 5;
            int K = 2;
            int[] vars = new int[K];
            VariationsGen(vars, 0, N);
        }
    }
}




     