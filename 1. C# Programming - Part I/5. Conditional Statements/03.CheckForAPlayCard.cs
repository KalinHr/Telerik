﻿using System;

/*Classical play cards use the following signs to designate the card face:
  `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string 
  and prints “yes” if it is a valid card sign or “no” otherwise. */

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write("Enter a card: ");
        string card = Console.ReadLine();
        if (card == "A" || card == "J" || card == "Q" || card == "K" || 
            card == "2" || card == "3" || card == "4" || card == "5" ||
            card == "6" || card == "7" || card == "8" || card == "9" ||
            card == "10")
            Console.WriteLine("yes");
        else 
            Console.WriteLine("no");
    }
}