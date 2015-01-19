using System;

/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
  Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
  from the binary representation of n while preserving all other bits in n.*/

    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            Console.Write("number = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("position = ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("value = ");
            int v = Convert.ToInt32(Console.ReadLine());
            int result = n;
                if (v == 0)
                {
                    int mask = ~(1 << p);
                    result = n & mask;
                }
                if (v == 1)
                {
                    int mask = 1 << p;
                    result = n | mask;
                }           
            Console.WriteLine(result);
        }
    }

