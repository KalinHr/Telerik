using System;

/*Write a program that generates and prints all possible cards from a standard deck of 52 cards.
  The cards should be printed using the classical notation (like 5 of spades, A of hearts, 
  9 of clubs; and K of diamonds).
  The card faces should start from 2 to A.
  Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
  Use 2 nested for-loops and a switch-case statement.*/

class PrintADeckOf52Cards
{
    static void Main()
    {   
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                string k;
                if (i <= 10)
                    k = Convert.ToString(i);
                else if (i == 11)
                    k = "J";
                else if (i == 12)
                    k = "Q";
                else if (i == 13)
                    k = "K";
                else
                    k = "A";
                switch (j)
                {
                    case 0:
                        Console.Write("{0,3}♣", k);
                        break;
                    case 1:
                        Console.Write("{0,3}♦", k);
                        break;
                    case 2:
                        Console.Write("{0,3}♥", k);
                        break;
                    default:
                        Console.Write("{0,3}♠", k);
                        break;
                }

            }
            Console.WriteLine();
        }
    }
}
