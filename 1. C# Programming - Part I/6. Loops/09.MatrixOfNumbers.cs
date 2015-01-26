using System;

/*Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the 
  examples below. Use two nested loops.
  n = 3   matrix
          1 2 3
          2 3 4
          3 4 5
 */

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int counter = 1;
        for (int i = 0; i < n; i++)
        {
            int helper = counter;
            for (int j = 0; j < n; j++)
            {
                Console.Write(helper + " ");
                helper++;
            }
            Console.WriteLine();
            counter++;
        }
    }
}