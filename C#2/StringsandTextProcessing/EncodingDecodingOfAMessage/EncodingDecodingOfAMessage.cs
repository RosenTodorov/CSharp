using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a 
 * sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
 * of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.*/

namespace EncodingDecodingOfAMessage
{
    class EncodingDecodingOfAMessage
    {
        static void Main()
        {
            string message = "Michael Jordan is the best.";
            string key = "the best";

            Console.WriteLine(Encrypt(message, key));
            Console.WriteLine();
            Console.WriteLine(Decrypt(Encrypt(message, key), key));
        }
        static string Encrypt(string message, string key)
        {
            int length = message.Length;
            StringBuilder encription = new StringBuilder(length);
            StringBuilder cipher = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                cipher.Append(key);
            }
            for (int i = 0; i < length; i++)
            {
                encription.Append((char)(message[i] ^ cipher[i]));
            }
            string result = encription.ToString();
            return result;
        }
        static string Decrypt(string message, string key)
        {
            string result = Encrypt(message, key);
            return result;
        }
    }
}

   