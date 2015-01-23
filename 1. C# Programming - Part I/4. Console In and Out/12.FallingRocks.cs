using System;
using System.Collections.Generic;
using System.Threading;


struct Object
{
    public int x;
    public int y;
    public string s;
    public ConsoleColor color;
}

class FallingRocks
{
    static void PrintOnPosition(int x, int y, string s, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(s);
    }

    static void Main(string[] args)
    {
        int playfieldWidth = 26;
        int lives = 5;
        double score = 0;
        string[] forms = {"^","^^","@","*","**","&","+","++","+++","%","$","#","##","!",".",";","-","--"};
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 45;


        Object dwarf = new Object();
        dwarf.x = 12;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.s = "(O)";
        dwarf.color = ConsoleColor.White;
        Random randomGenerator = new Random();
        List<Object> rocks = new List<Object>();
        while (true)
        {
            bool hitten = false;
            for (int i = 0; i <= 1; i++)
            {
                Object newRock = new Object();
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.y = 0;
                newRock.s = forms[randomGenerator.Next(0, forms.Length)];
                int chanse = randomGenerator.Next(1, 6);
                switch (chanse)
                {
                    case 1:
                        newRock.color = ConsoleColor.Yellow;
                        break;
                    case 2:
                        newRock.color = ConsoleColor.Blue;
                        break;
                    case 3:
                        newRock.color = ConsoleColor.Green;
                        break;
                    case 4:
                        newRock.color = ConsoleColor.Cyan;
                        break;
                    default:
                        newRock.color = ConsoleColor.Magenta;
                        break;
                }
                rocks.Add(newRock);
            }
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                    if (dwarf.x > 0)
                        dwarf.x--;
                if (pressedKey.Key == ConsoleKey.RightArrow)
                    if (dwarf.x < playfieldWidth - 3)
                        dwarf.x++;
            }

            List<Object> newList = new List<Object>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Object oldRock = rocks[i];
                Object newRock = new Object();
                newRock.color = oldRock.color;
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.s = oldRock.s;

                if (newRock.y == dwarf.y && newRock.x == dwarf.x ||
                    newRock.y == dwarf.y && newRock.x == dwarf.x + 1 ||
                    newRock.y == dwarf.y && newRock.x == dwarf.x + 2 ||
                    newRock.s.Length >= 2 && newRock.y == dwarf.y && newRock.x + 1 == dwarf.x ||
                    newRock.s.Length == 3 && newRock.y == dwarf.y && newRock.x + 2 == dwarf.x)
                {
                    lives--;
                    hitten = true;
                    if (lives == 0)
                    {
                        PrintOnPosition(8, 8, "GAME OVER", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);                    
                    }
                }
                if (newRock.y < Console.WindowHeight)
                    newList.Add(newRock);
            }
            rocks = newList;
            Console.Clear();
            if (hitten)
            {
                rocks.Clear();
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.s, ConsoleColor.Red);
            }
            else
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.s, dwarf.color);
            foreach (Object rock in rocks)
            {
                PrintOnPosition(rock.x, rock.y, rock.s, rock.color);
            }
            score = score + 0.2;
            PrintOnPosition(29, 4, "Lives: " + lives);
            PrintOnPosition(29, 5, "Score: " + (int)score);
            PrintOnPosition(26, 0, "|");
            PrintOnPosition(26, 1, "|");
            PrintOnPosition(26, 2, "|");
            PrintOnPosition(26, 3, "|");
            PrintOnPosition(26, 4, "|");
            PrintOnPosition(26, 5, "|");
            PrintOnPosition(26, 6, "|");
            PrintOnPosition(26, 7, "|");
            PrintOnPosition(26, 8, "|");
            PrintOnPosition(26, 9, "|");
            PrintOnPosition(26, 10, "|");
            PrintOnPosition(26, 11, "|");
            PrintOnPosition(26, 12, "|");
            PrintOnPosition(26, 13, "|");
            PrintOnPosition(26, 14, "|");
            PrintOnPosition(26, 15, "|");
            PrintOnPosition(26, 16, "|");
            PrintOnPosition(26, 17, "|");
            PrintOnPosition(26, 18, "|");
            PrintOnPosition(26, 19, "|");


            Thread.Sleep(150);

        }
    }
}

