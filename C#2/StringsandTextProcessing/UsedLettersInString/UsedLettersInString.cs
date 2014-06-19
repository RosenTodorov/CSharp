using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that reads a string from the console and prints all 
   different letters in the string along with information how many times each letter is found. */

namespace UsedLettersInString
{
    class UsedLettersInString
    {
        static void Main()
        {
            /*  string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
              string newText = text.ToLower();

              int index = 0;
              List<char> letters = new List<char>();

              while (index <= text.Length - 1)
              {
                  int letterCount = 0;
                  char letter = newText[index];

                  if (letters.Contains(letter))
                  {
                      index++;
                      continue;
                  }
                  else
                  {
                      if (letter == '.' || letter == ',' || letter == ' ' || letter == ':' || letter == '?')
                      {
                          index++;
                          continue;
                      }
                      else
                      {
                          for (int i = 0; i < newText.Length; i++)
                          {
                              if (letter == text[i])
                              {
                                  letterCount++;
                              }
                          }
                      }
                      letters.Add(letter);
                      Console.WriteLine("\'{0}\' - {1}", letter, letterCount);
                  }
                  index++;
              }
          }
      }
  } */

            // second way:
            string[] specialSigns = { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+" };

            string input = Console.ReadLine();
            string newInput = input.ToLower();

            for (int i = 0; i < specialSigns.Length; i++)
            {
                newInput = newInput.Replace(specialSigns[i], string.Empty);
            }

            Dictionary<char, int> allLetters = new Dictionary<char, int>();

            for (int i = 0; i < newInput.Length; i++)
            {
                if (allLetters.ContainsKey(newInput[i]))
                {
                    allLetters[newInput[i]]++;
                }
                else
                {
                    allLetters.Add(newInput[i], 1);
                }
            }

            var sortedLetters = allLetters.OrderBy(x => x.Key);
            foreach (var item in sortedLetters)
            {
                Console.WriteLine("Letter --> {0} - Number --> {1}", item.Key, item.Value);
            }
        }
    }
}

