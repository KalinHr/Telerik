using System;

/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that 
  has maximal sum of its elements.*/

class Program
{
    static int SumOfMatrix(int[,] matrix, int x, int y)
    {
        int sum = 0;
        for (int i = x; i < x + 3; i++)
            for (int j = y; j < y + 3; j++)
                sum += matrix[i, j]; 
        return sum;
    }

    static void PrintMatrix(int[,] matrix, int x, int y, int n, int m)
    {
        for (int i = x; i < x + n; i++)
        {
            for (int j = y; j < y + m; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,m]; 

        Random random = new Random();
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                matrix[i, j] = random.Next(0, 100);

        PrintMatrix(matrix, 0, 0, n, m);

        int x = 0;
        int y = 0;
        int sum = 0;
        for (int i = 0; i < n - 2; i++)
            for (int j = 0; j < m - 2; j++)
                if (SumOfMatrix(matrix, i, j) > sum)
                {
                    x = i;
                    y = j;
                    sum = SumOfMatrix(matrix, i, j);
                }

        PrintMatrix(matrix, x, y, 3, 3);
    }
}
