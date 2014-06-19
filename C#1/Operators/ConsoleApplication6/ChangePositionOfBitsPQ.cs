using System;



class ChangePositionOfBitsPQ
{
    static void Main()
    {
        Console.WriteLine(@"!!'p' shouldn't be greater than 'q', and 'k'+'q' shouldn't be greater than 32!!");
        Console.WriteLine("First write the number, then p->q->k");
        uint number;
        byte q, k, p;

        bool isNum = uint.TryParse(Console.ReadLine(), out number);
        bool isP = byte.TryParse(Console.ReadLine(), out p);
        bool isQ = byte.TryParse(Console.ReadLine(), out q);
        bool isK = byte.TryParse(Console.ReadLine(), out k);

        string str = Convert.ToString(number, 2).PadLeft(32, '0');
        char[] array = new char[str.Length];
        Console.WriteLine("Before : {0}", str);

        if ((isNum && isP && isQ && isK) && (p < q && (k + q) <= 32))
        {
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = str[i];
            }
            for (int i = 0; i < k; i++)
            {
                char t = array[str.Length - q];
                array[str.Length - q] = array[str.Length - p];
                array[str.Length - p] = t;
                q++;
                p++;
            }
            Console.Write("After :  ");

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        else Console.WriteLine("Wrong Input");
    }
}
