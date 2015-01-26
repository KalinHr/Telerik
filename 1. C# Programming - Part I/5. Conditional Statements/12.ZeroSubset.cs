using System;

/*We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
  Assume that repeating the same subset several times is not a problem.*/

class ZeroSubset
{
    static void Main()
    {
        int[] n = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("number[{0}] = ", i);
            n[i] = Convert.ToInt32(Console.ReadLine());
        }
        if (n[0] + n[1] == 0)
            Console.WriteLine("{0} + {1} = 0", n[0], n[1]);
        if (n[0] + n[2] == 0)
            Console.WriteLine("{0} + {1} = 0", n[0], n[2]);
        if (n[0] + n[3] == 0)
            Console.WriteLine("{0} + {1} = 0", n[0], n[3]);
        if (n[0] + n[4] == 0)
            Console.WriteLine("{0} + {1} = 0", n[0], n[4]);
        if (n[1] + n[2] == 0)
            Console.WriteLine("{0} + {1} = 0", n[1], n[2]);
        if (n[1] + n[3] == 0)
            Console.WriteLine("{0} + {1} = 0", n[1], n[3]);
        if (n[1] + n[4] == 0)
            Console.WriteLine("{0} + {1} = 0", n[1], n[4]);
        if (n[2] + n[3] == 0)
            Console.WriteLine("{0} + {1} = 0", n[2], n[3]);
        if (n[2] + n[4] == 0)
            Console.WriteLine("{0} + {1} = 0", n[2], n[4]);
        if (n[3] + n[4] == 0)
            Console.WriteLine("{0} + {1} = 0", n[3], n[4]);
        if (n[0] + n[1] + n[2] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[0], n[1], n[2]);
        if (n[0] + n[1] + n[3] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[0], n[1], n[3]);
        if (n[0] + n[1] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[0], n[1], n[4]);
        if (n[0] + n[2] + n[3] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[0], n[2], n[3]);
        if (n[0] + n[2] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[0], n[2], n[4]);
        if (n[0] + n[3] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[0], n[3], n[4]);
        if (n[1] + n[2] + n[3] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[1], n[2], n[3]);
        if (n[1] + n[2] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[1], n[2], n[4]);
        if (n[1] + n[3] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[1], n[3], n[4]);
        if (n[2] + n[3] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} = 0", n[2], n[3], n[4]);
        if (n[0] + n[1] + n[2] + n[3] == 0)
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", n[0], n[1], n[2], n[3]);
        if (n[0] + n[1] + n[2] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", n[0], n[1], n[2], n[4]);
        if (n[0] + n[1] + n[3] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", n[0], n[1], n[3], n[4]);
        if (n[0] + n[2] + n[3] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", n[0], n[2], n[3], n[4]);
        if (n[1] + n[2] + n[3] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", n[1], n[2], n[3], n[4]);
        if (n[0] + n[1] + n[2] + n[3] + n[4] == 0)
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", n[0], n[1], n[2], n[3], n[4]);
    }
}
