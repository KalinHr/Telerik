using System;

/*Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix 
  holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
  n = 3   matrix
          1 2 3
          8 9 4
          7 6 5
*/

class SpiralMatrix
{
    static int[,] matrix;
    static int number = 1;
    static int N;

    static void Spiral(int row, int col)
    {
        if (number >= N * N)
            return;
        else
        {
            // right
            while ((col < N) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                col++;
                number++;
            }
            col--;
            row++;
            // down
            while ((row < N) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                row++;
                number++;
            }
            row--;
            col--;
            // left
            while ((col >= 0) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                col--;
                number++;
            }
            col++;
            row--;
            // up
            while ((row > 0) && (matrix[row, col] == 0))
            {
                matrix[row, col] = number;
                row--;
                number++;
            }

            
            if (matrix[row, col] != 0)
            {
                row++;
                col++;
                Spiral(row, col);
            }
        }
    }

    static void Main()
    {
        Console.Write("n = ");
        N = int.Parse(Console.ReadLine());
        matrix = new int[N, N];

        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                matrix[i, j] = 0;

        Spiral(0, 0);

        if (N % 2 != 0)
            matrix[N / 2, N / 2] = N * N;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write("{0,4}", matrix[i, j]);
            Console.WriteLine();
        }
    }
}
