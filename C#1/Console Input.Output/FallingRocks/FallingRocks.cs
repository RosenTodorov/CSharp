using System;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{
    struct Object
    {
        public int x1;
        public int x2;
        public int x3;
        public int y;
        public string str;
        public char firstSymbol;
        public char c;
        public char thirdSymbol;
        public ConsoleColor color;

    }

    class GameFallRocks
    {
        static void PrintOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(c);
        }
        static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            int playfieldWidht = 60;
            int score = 0;
            int livesCount = 5;
            int rockWidth;
            char randomRockSymbol;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.WindowWidth = 80;
            Object dwarf = new Object();
            dwarf.x1 = 29;
            dwarf.x2 = 30;
            dwarf.x3 = 31;
            dwarf.y = Console.WindowHeight - 1;
            dwarf.firstSymbol = '(';
            dwarf.c = 'O';
            dwarf.thirdSymbol = ')';
            dwarf.color = ConsoleColor.White;
            Random randomGenerator = new Random();
            List<Object> rocks = new List<Object>();

            while (true)
            {
                bool hitted = false;
                {
                    char[] c = new char[11] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
                    int all = randomGenerator.Next(0, c.Length);
                    int chance = randomGenerator.Next(0, 100);

                    if (chance < 2)
                    {
                        Object newRock = new Object();
                        newRock.color = ConsoleColor.Yellow;
                        newRock.c = '?';
                        newRock.x1 = randomGenerator.Next(0, playfieldWidht);
                        newRock.y = 0;
                        rocks.Add(newRock);
                    }
                    else if (chance < 20)
                    {
                        Object newRock = new Object();
                        newRock.color = ConsoleColor.Cyan;
                        newRock.c = 'B';
                        newRock.x1 = randomGenerator.Next(0, playfieldWidht);
                        newRock.y = 0;
                        rocks.Add(newRock);

                    }
                    else
                    {
                        rockWidth = randomGenerator.Next(1, 5);
                        randomRockSymbol = c[randomGenerator.Next(c.Length)];
                        Object newRock = new Object();
                        newRock.color = (ConsoleColor)randomGenerator.Next(5, 15);
                        newRock.x1 = randomGenerator.Next(0, playfieldWidht);
                        newRock.y = 0;
                        newRock.c = randomRockSymbol;
                        for (int i = 0; i < rockWidth; i++)
                        {
                            rocks.Add(newRock);
                            if (newRock.x1 < playfieldWidht - 1)
                            {
                                newRock.x1++;
                            }
                        }
                    }
                }
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedkey = Console.ReadKey(true);

                    if (pressedkey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.x1 - 1 >= 0)
                        {
                            dwarf.x1 = dwarf.x1 - 1;
                            dwarf.x2 = dwarf.x2 - 1;
                            dwarf.x3 = dwarf.x3 - 1;
                        }
                    }
                    else if (pressedkey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.x1 - 1 < playfieldWidht)
                        {
                            dwarf.x1 = dwarf.x1 + 1;
                            dwarf.x2 = dwarf.x2 + 1;
                            dwarf.x3 = dwarf.x3 + 1;
                        }
                    }
                }
                List<Object> newList = new List<Object>();

                for (int i = 0; i < rocks.Count; i++)
                {
                    Object oldRock = rocks[i];
                    Object newRock = new Object();
                    newRock.x1 = oldRock.x1;
                    newRock.y = oldRock.y + 1;
                    newRock.c = oldRock.c;
                    newRock.color = oldRock.color;

                    if (newRock.c == 'B' && newRock.y == dwarf.y && newRock.x1 == dwarf.x1)
                    {
                        livesCount++;
                    }
                    if (newRock.c == '?' && newRock.y == dwarf.y && newRock.x1 == dwarf.x1)
                    {
                        livesCount = (livesCount * 2);
                    }
                    if (newRock.c != '~' && newRock.c != 'B' && newRock.c != '?' && newRock.y == dwarf.y && newRock.x1 == dwarf.x1)
                    {
                        livesCount--;
                        hitted = true;
                        if (livesCount <= 0)
                        {
                            PrintStringOnPosition(25, 10, "GAME OVER!!!", ConsoleColor.Red);
                            PrintStringOnPosition(25, 12, "Press [enter] to exit", ConsoleColor.Red);

                            Console.ReadLine();
                            Environment.Exit(0);

                        }
                    }
                    if (newRock.y < Console.WindowHeight)
                    {
                        newList.Add(newRock);
                    }
                    else
                    {
                        score++;
                    }
                }
                rocks = newList;
                Console.Clear();

                if (hitted)
                {
                    rocks.Clear();
                    PrintOnPosition(dwarf.x1, dwarf.y, 'X', ConsoleColor.Red);
                }
                else
                {
                    PrintOnPosition(dwarf.x1, dwarf.y, dwarf.firstSymbol, dwarf.color);
                    PrintOnPosition(dwarf.x2, dwarf.y, dwarf.c, dwarf.color);
                    PrintOnPosition(dwarf.x3, dwarf.y, dwarf.thirdSymbol, dwarf.color);
                }
                foreach (Object rock in rocks)
                {
                    PrintOnPosition(rock.x1, rock.y, rock.c, rock.color);
                }
                PrintStringOnPosition(66, 5, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(66, 10, "Score: " + score, ConsoleColor.White);

                Console.Beep(223, 35);

                Thread.Sleep(150);
            }
        }
    }
}

