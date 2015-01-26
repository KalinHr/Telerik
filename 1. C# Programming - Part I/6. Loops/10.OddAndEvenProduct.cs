using System;

/*You are given n integers (given in a single line, separated by a space).
  Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
  Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("n integers in a single line, separated by a space: ");
        string s = Console.ReadLine() + " ";
        int evenProduct = 1;
        int oddProduct = 1;
        string helper = "";
        bool odd = true;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
                if (odd)
                {
                    oddProduct *= int.Parse(helper);
                    helper = "";
                    odd = false;
                }
                else
                {
                    evenProduct *= int.Parse(helper);
                    helper = "";
                    odd = true;
                }
            else
                helper = helper + s[i];
        }
        if (evenProduct != oddProduct || s.Length == 2)
            Console.WriteLine("no");
        else
            Console.WriteLine("yes");
    }
}
